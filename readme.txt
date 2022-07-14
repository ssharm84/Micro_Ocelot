Microservice Architecture:
1.Planning & Designing:
a.Facade Pattern - implemented by API Gateway -We have the package Ocelot

User ----------ApiGateway------------------Customer
                                            Order

How to register Ocelot.json file in ApiGateway service
ocelot.json file acts as a route table for customer service and other service

.ConfigureAppConfiguration((hostingContext, config) =>
               {
                   config.AddJsonFile("ocelot.json");//loading ocelot.json file before calling Startup
               })

 Api Gateway - http://localhost:5001......................Gateway Endpoint
 ApiGateway can never have a controller

 Customer Service - http://localhost:5002/Customer/CustomerDetails

 Order Service - http://localhost:5003/Order/OrderDetails

{
    "Routes": [],
    "GlobalConfiguration": {}
}

Ocelot consists of Route table of multiple services and GlobalConfiguration with global endpoint

 
LOH - If Object size = 80kb , CLR sends the Profiler into large object Heap. We implement Dispose Pattern
SOH - If object size < 80kb..This is managed by Finalize.


b. Response Aggregation Principle
c.CQRS - Command Query Responsibility Segregation
d.MediatR Pattern
e.Messaging-RabbitMq/Kafka as Message Broker for subscriber & consumer
f. SAGA for Transaction

2.Deployment:
a.Docker
b.Kubernetes
c.CI CD

Upstream - real end point
Downstream - Actual end point of the service
A service can have only 1 upstream n downstream

--------------------------------------------------------

