﻿using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IColorService
	{
		IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetByColorId(int colorId);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
    }
}

