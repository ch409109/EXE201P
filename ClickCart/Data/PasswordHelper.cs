namespace ClickCart.Data
{
	public static class PasswordHelper
	{
		public static string ToHashPassword(string password)
		{
			return BCrypt.Net.BCrypt.HashPassword(password);
		}
		public static bool VerifyPassword(string password, string passwordHash)
		{
			return BCrypt.Net.BCrypt.Verify(password, passwordHash);
		}
	}
}
