using ClickCart.Models;
using ClickCart.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Pages.Admin.Dashboard
{
    public class IndexModel : PageModel
    {
        private readonly ClickCartDbContext _context;
		private readonly EmailService _emailService;

		public IndexModel(ClickCartDbContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public class MonthlyRevenue
        {
            public int Month { get; set; }
            public decimal TotalRevenue { get; set; }
        }

        public IList<Order> Orders { get; set; } = default!;
        public SelectList YearList { get; set; } = default!;
        public SelectList MonthList { get; set; } = default!;
        public List<MonthlyRevenue> MonthlyRevenueData { get; set; } = new List<MonthlyRevenue>();
        [BindProperty(SupportsGet = true)]
        public int? SelectedYear { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? SelectedMonth { get; set; }

        public async Task OnGetAsync()
        {
            await LoadDataAsync();
			//await SendSurveyEmailBody();
		}

        private async Task LoadDataAsync()
        {
            YearList = new SelectList(await _context.Orders
                .Select(o => o.CreatedAt.Year)
                .Distinct()
                .ToListAsync());
            MonthList = new SelectList(Enumerable.Range(1, 12).Select(i => new { Value = i, Text = $"Tháng {i}" }), "Value", "Text");

            MonthlyRevenueData = Enumerable.Range(1, 12).Select(month => new MonthlyRevenue
            {
                Month = month,
                TotalRevenue = 0
            }).ToList();

            var revenueData = await _context.Orders
                .Where(o => o.CreatedAt.Year == SelectedYear && o.PaymentStatus == "Paid")
                .GroupBy(o => o.CreatedAt.Month)
                .Select(g => new MonthlyRevenue
                {
                    Month = g.Key,
                    TotalRevenue = g.Sum(b => b.TotalAmount)
                }).ToListAsync();

            foreach (var data in revenueData)
            {
                MonthlyRevenueData.First(m => m.Month == data.Month).TotalRevenue = data.TotalRevenue;
            }
        }


        public async Task<IActionResult> SendSurveyEmailBody()
        {
            try
            {
                string surveyLink = "https://forms.gle/DwSvcYKASMMTy22F7";
                var listUser = _context.Users.ToList();

                foreach (var customer in listUser)
                {
                    string emailBody = $@"
                <html>
                <head>
                    <style>
                        .email-container {{
                            font-family: Arial, sans-serif;
                            line-height: 1.6;
                            color: #333;
                            max-width: 600px;
                            margin: 0 auto;
                        }}
                        .email-header {{
                            background-color: #0288D1; /* Màu xanh dương đậm nhạt */
                            padding: 15px;
                            text-align: center;
                            border-bottom: 3px solid #0277BD;
                            border-radius: 5px 5px 0 0;
                        }}
                        .email-body {{
                            padding: 25px;
                            background: url('https://www.transparenttextures.com/patterns/light-paper-fibers.png') repeat;
                            background-size: 100px;
                        }}
                        .email-footer {{
                            background-color: #0288D1;
                            padding: 15px;
                            text-align: center;
                            font-size: 12px;
                            color: #fff;
                            border-radius: 0 0 5px 5px;
                        }}
                        .survey-btn {{
                            display: inline-block;
                            padding: 12px 25px;
                            background-color: #03A9F4; /* Màu xanh dương sáng */
                            color: white;
                            text-decoration: none;
                            border-radius: 5px;
                            margin: 15px 0;
                            transition: background-color 0.3s;
                        }}
                        .survey-btn:hover {{
                            background-color: #0288D1;
                            color: white;
                        }}
                        .highlight {{
                            color: #03A9F4;
                            font-weight: bold;
                        }}
                    </style>
                </head>
                <body>
                    <div class='email-container'>
                        <div class='email-header'>
                            <h1 style='color: #fff; margin: 0;'>ClickCart - Chúng tôi cần ý kiến của bạn!</h1>
                        </div>
                        <div class='email-body'>
                            <p>Xin chào <strong>{customer.FullName}</strong>,</p>
                            <p>Cảm ơn bạn đã tin tưởng và lựa chọn ClickCart cho nhu cầu mua sắm của mình. Chúng tôi luôn mong muốn mang đến trải nghiệm tốt nhất cho khách hàng, và ý kiến của bạn chính là điều giúp chúng tôi cải thiện mỗi ngày.</p>
                
                            <h3 style='color: #0288D1;'>Hãy dành chút thời gian chia sẻ với chúng tôi!</h3>
                            <p>Chúng tôi rất mong nhận được cảm nhận của bạn về sản phẩm và dịch vụ của ClickCart. Chỉ mất khoảng <strong>2-3 phút</strong>, bạn có thể giúp chúng tôi hiểu rõ hơn những gì cần thay đổi và hoàn thiện:</p>
                            <a href='{surveyLink}' class='survey-btn'>Tham gia khảo sát</a>
                
                            <p>Mọi ý kiến từ bạn, dù là lời khen hay góp ý, đều rất quý giá đối với chúng tôi. Đây là cơ hội để bạn cùng chúng tôi xây dựng một ClickCart ngày càng tốt hơn.</p>

                            <p>Nếu bạn có bất kỳ câu hỏi nào, vui lòng liên hệ qua:</p>
                            <ul>
                                <li>Fanpage: <a href='https://www.facebook.com/profile.php?id=61571964152044' target='_blank' style='color: #03A9F4; text-decoration: none;'>ClickCart Fanpage</a></li>
                                <li>Email: <a href='mailto:clickcart.emailservice@gmail.com' style='color: #03A9F4; text-decoration: none;'>support@clickcart.vn</a></li>
                            </ul>

                            <p>Cảm ơn bạn đã dành thời gian quý báu để hỗ trợ chúng tôi. Chúng tôi rất trân trọng sự đóng góp của bạn!</p>
                            <p>Trân trọng,<br>Đội ngũ ClickCart</p>
                        </div>
                        <div class='email-footer'>
                            <p>© {DateTime.Now.Year} ClickCart. All rights reserved.</p>
                            <p>Liên hệ: 0968596067 | Email: clickcart.emailservice@gmail.com</p>
                        </div>
                    </div>
                </body>
                </html>";

                    await _emailService.SendEmailAsync(
                        toEmail: customer.Email,
                        subject: "ClickCart - Mời bạn chia sẻ ý kiến qua khảo sát",
                        body: emailBody
                    );
                }
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
			return new JsonResult(new { success = true });
		}
	}
}
