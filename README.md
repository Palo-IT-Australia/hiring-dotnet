# Dev Setup (Optional)
## Server
run `dotnet ef database update` in the server folder (`Wallbaord`)

## Client
run `npm install` or `yarn install` in the client folder (`Wallboard>ClientApp`)

## Running the application
The server is setup to run the client application. `dotnet run`


# Challanges

## Challange 1 (DOTNET) - Register the Custom Authorization Middleware
### Description
One of the developers has written some custom authorisation middleware.
The middleware can be found in `Middleware>CustomAuthMiddleware.cs`.
They have also made a handy extension method to expose the custom middleware through IApplicationProvider. The extension method is found in `Middleware>MiddlewareEntensions.cs`.

### Acceptance Criteria
- Add the custom middleware into the app pipeline

## Challange 2 (REACT) - Include header to satisfy Custom Authorization Middleware
### Description
Now that the custom authorisation middleware is being used, our requests from the client must satisfy it. Open `ClientApp>src>App.tsx`. There is a function called `onSubmitPost` that is making post requests to the server. We need to include a header that will satisfy the custom auth middleware.

### Acceptance Criteria
- onSubmitPost method is sending a 'speacial-auth' header.
- Header will satisfy the 'CustomAuthMiddleware' condition on the server.

## Challange 3 (DOTNET) - Censor posts with the PostCensorService
### Description
There is a service located at `Services>PostCensorService.cs`. This service provides a way to censor banned words from a post before the post is added into the database. Please register the service, and then implement the method `CensorPost` in the `CreatePost` endpoint of the `WallboardController`. The wallboard controller is found at `Controller>WallboardController.cs`.

### Acceptance Criteria
- PostCensorService is registered with the service container.
- PostCensorService is dependancy injected into the WallboardController.
- The CensorPost method is being used to censor posts before being added into the database.


## Challange 4 (DOTNET) - Finish the implementation of the CustomFilterCollection
### Description
Inside the Wallboard Controller `GetPosts` method in `Controllers>WallboardController.cs` a custom extension with is being used to filter the posts being returned. The method is called `CustomerFilterCollection`. If you look at the implementation of the method, you will see it takes an `IQueryable` and a `Expression<Func<T, bool>>` predicate. Finish the implementation by using the predicate to filter the posts, and return the filtered collection.

### Acceptance Criteria
- `CustomerFilterCollection` imlementation is completed.
- Wallboard controller `GetPosts` method is filtering posts using the predicate passed to `CustomerFilterCollection`