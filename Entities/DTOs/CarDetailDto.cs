﻿using System;
using Core.Entities;

namespace Entities.DTOs
{
	public class CarDetailDto:IDto
	{
		public int CarId { get; set; }
		public string Description { get; set; }
		public string ColorName { get; set; }
		public string BrandName { get; set; }
		public double DailyPrice { get; set; }
	}
}

