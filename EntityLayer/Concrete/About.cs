using System;
namespace EntityLayer.Concrete
{
	public class About
	{
		public About()
		{
		}
		public int AboutID { get; set; }
		public int Title { get; set; }
		public string Description { get; set; }
		public string Image1 { get; set; }
		public string Title2 { get; set; }
		public string Description2 { get; set; }
        public bool Status { get; set; }
    }
}

