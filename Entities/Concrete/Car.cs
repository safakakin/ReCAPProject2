﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Car:IEntity
	{
		public int CarId { get; set; }
		public int BrandId { get; set; }
		public int ColorId { get; set; }
		public int ModelYear { get; set; }
		public double DailyPrice { get; set; }
		public string Description { get; set; }

	}
}

