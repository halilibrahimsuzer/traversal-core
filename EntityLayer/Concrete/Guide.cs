﻿using System;
namespace EntityLayer.Concrete
{
	public class Guide
	{
		public int GuideID { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? Image { get; set; }
		public string? TwitterURL { get; set; }
		public string? IntagramURL { get; set; }
		public bool Status { get; set; }
	}
}

