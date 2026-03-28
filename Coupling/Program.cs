using Coupling;
using System;

var order = new Order(new EmailSender());
order.PlaceOrder();

var order2 = new Order(new SmsSender());
order2.PlaceOrder();