using ClickCart.Models;

namespace ClickCart.Services.Implementations
{
    public class OrderService
    {
        private readonly ClickCartDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OrderService(ClickCartDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Order> ProcessOrderAsync(int totalAmount, List<(int ProductId, int Quantity)> selectedItems)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var userIdClaim = _httpContextAccessor.HttpContext?.User.FindFirst("UserId");
                if (userIdClaim == null)
                {
                    throw new UnauthorizedAccessException("User not authorized.");
                }
                int userId = int.Parse(userIdClaim.Value);

                // Tạo đơn hàng mới
                var order = new Order
                {
                    UserID = userId,
                    TotalAmount = totalAmount,
                    ShippingAddress = "Default Address", // Bạn có thể thay đổi logic này để lấy địa chỉ từ session hoặc form
                    PaymentStatus = "Pending",
                    PaymentGateway = "VNPay",
                    CreatedAt = DateTime.Now
                };

                _context.Orders.Add(order);
                await _context.SaveChangesAsync();

                foreach (var (productId, quantity) in selectedItems)
                {
                    var product = await _context.Products.FindAsync(productId);
                    if (product != null && product.Stock >= quantity)
                    {
                        var orderDetail = new OrderDetail
                        {
                            OrderID = order.OrderID,
                            ProductID = productId,
                            Quantity = quantity,
                            Price = product.Price * quantity
                        };

                        _context.OrderDetails.Add(orderDetail);

                        product.Stock -= quantity;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Insufficient stock for product {product?.ProductName}");
                    }
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return order;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<bool> UpdateOrderPaymentStatusAsync(int orderId, string status)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null)
            {
                throw new InvalidOperationException("Order not found.");
            }

            order.PaymentStatus = status;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
