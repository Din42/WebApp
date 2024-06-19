namespace WebApp.Models
{
	//модель описывает обработку возможных ошибок которые могут возникнуть на сайте
	public class ErrorViewModel
	{
		public string? RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
}
