#### 1.3.9 November 01 2018 ####
* Added support for Akka.NET v1.3.9
* Added new [`UseAutoFac` extension method](https://github.com/akkadotnet/Akka.DI.AutoFac/pull/16):

By using an extension method of `ActorSystem`, the relationship between the `ActorSystem` and the `container` becomes clear and we can immediately see that the `ActorSystem` is being _modified_ to use the `container` and that's why you're good to use the `system.DI()` method from that point on.

```csharp
system.UseAutofac(container);
```
 
We also no longer need to create the instance of `AutoFacDependencyResolver` ourselves and/or create a variable. For convenience, for the rare cases where we do need to use the `AutoFacDependencyResolver` instance created, we can use an overload of the `UseAutofac` extension method:

```
system.UseAutofac(container, out var propsResolver);
```
#### 1.3.0 August 15 2017 ####
.NET Standard 1.6 support and integration with Akka.NET v1.3.0

#### 1.2.3 July 12 2017 ####

Support for Akka 1.2.3

#### 1.2.2 July 6 2017 ####

Support for Akka 1.2.2
Updated Autofac to 4.6.0

#### 1.2.0 June 23 2017 ####

Support for Akka 1.2.0

#### 1.1.2 October 10 2016 ####

Support for Akka 1.1.2

#### 1.0.8 March 28 2016 ####

Support for Akka 1.0.8

#### 1.0.7 April 7 2016 ####

Support for Akka 1.0.7