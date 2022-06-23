## Challange 1 - Register the Custom Authorization Middleware
### Description
One of the developers has written some custom authorisation middleware.
The middleware can be found in `Middleware>CustomAuthMiddleware.cs`.
They have also made a handy extension method to expose the custom middleware through IApplicationProvider. The extension method is found in `Middleware>MiddlewareEntensions.cs`.

### Acceptant Criteria
- Add the custom middleware into the app pipeline

## Challange 2 - Censor posts with the PostCensorService
### Description
There is a service located at `Services>PostCensorService.cs`. This service provides a way to censor banned words from a post before the post is added into the database. Please register the service, and then implement the method `CensorPost` in the `CreatePost` endpoint of the `WallboardController`. The wallboard controller is found at `Controller>WallboardController.cs`.

### Acceptant Criteria
- PostCensorService is registered with the service container.
- PostCensorService is dependancy injected into the WallboardController.
- The CensorPost method is being used to censor posts before being added into the database.
