using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio__ENUM___COMP_.Entities.Enums
    {
    enum OrderStatus : int
    { 
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }

}