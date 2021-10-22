using MOrder.Infrastructure.DTOs.Output;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.Utils.Mapping
{
    public static class UserMapper
    {
        public static OutLogin Map(OutPotrosac potrosac)
        {
            return new OutLogin
            {
                Username = potrosac.UserName
            };
        }
    }
}
