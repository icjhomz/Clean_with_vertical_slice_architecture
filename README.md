How To Structure Your Projects with Clean Architecture and Vertical Slices
I found that combining Clean Architecture with Vertical Slices is a great architecture design for the complex applications. In small applications or in applications that don’t have complex business logic, you can use Vertical Slices without Clear Architecture.

As a core, I use Clean Architecture layers and combine them with Vertical Slices.

Here is how the layers are being modified:

Domain: contains core business objects such as entities (remains unchanged).
Infrastructure: implementation of external dependencies like database, cache, message queue, authentication provider, etc (remains unchanged).
Application and Presentation Layers are combined with Vertical Slices.
