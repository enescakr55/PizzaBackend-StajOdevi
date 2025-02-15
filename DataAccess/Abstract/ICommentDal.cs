﻿using Core.CrudOperations;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICommentDal:ICrudBase<Comment>
    {
        List<CommentInfo> GetCommentInfo(Expression<Func<CommentInfo, bool>> filter = null);
    }
}
