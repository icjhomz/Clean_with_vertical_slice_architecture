# How To Structure Your Projects with Clean Architecture and Vertical Slices

I found that combining Clean Architecture with Vertical Slices is a great architecture design for complex applications. In small applications or in applications that don’t have complex business logic, you can use Vertical Slices without Clean Architecture.

As a core, I use Clean Architecture layers and combine them with Vertical Slices.

### Here is how the layers are being modified:

- **Domain:** contains core business objects such as entities (remains unchanged).
- **Infrastructure:** implementation of external dependencies like database, cache, message queue, authentication provider, etc. (remains unchanged).
- **Application and Presentation Layers** are combined with Vertical Slices.

### Summary

I find the best way to structure complex projects is by using Domain and Infrastructure Layers from Clean Architecture and combining the Application and Presentation Layers into Vertical Slices.

- The **Domain Layer** allows you to encapsulate business rules within the corresponding entities.
- The **Infrastructure Layer** helps avoid code duplication for external integrations.
- **Vertical Slices** are a fantastic way to achieve high cohesion within each slice and low coupling across different slices.
