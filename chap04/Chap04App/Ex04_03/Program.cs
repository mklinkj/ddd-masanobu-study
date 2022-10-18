// See https://aka.ms/new-console-template for more information
using Ex04_03;

var 운송서비스 = new TransportService();
var 지점a = new PhysicalDistributionBase();
var 지점b = new PhysicalDistributionBase();

var 화물a = new Baggage(new BaggageId("화물a"));

운송서비스.Transport(지점a, 지점b, 화물a);