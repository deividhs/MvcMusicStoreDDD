﻿using System;
using MvcMusicStore.Domain.Interfaces.Validation;

namespace MvcMusicStore.Domain.Entities.Specifications.OrderSpecs
{
    public class OrderCityIsRequiredSpec : ISpecification<Order>
    {
        public bool IsSatisfiedBy(Order order)
        {
            return !String.IsNullOrEmpty(order.City) && !String.IsNullOrWhiteSpace(order.City);
        }
    }
}
