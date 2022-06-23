# Dev Setup (Optional)
## Server
The database migrations have already been commited to the repo.
run `dotnet ef database update` in the server folder (`Wallbaord`)


# Challenges

## Challenge 1 - Register the Custom Authorization Middleware
### Description
One of the developers has written some custom authorisation middleware.
The middleware can be found in `Middleware>CustomAuthMiddleware.cs`.
They have also made a handy extension method to expose the custom middleware through IApplicationProvider. The extension method is found in `Middleware>MiddlewareEntensions.cs`.

### Acceptance Criteria
- Add the custom middleware into the app pipeline

## Challenge 2 - Censor posts with the PostCensorService
### Description
There is a service located at `Services>PostCensorService.cs`. This service provides a way to censor banned words from a post before the post is added into the database. Please register the service, and then implement the method `CensorPost` in the `CreatePost` endpoint of the `WallboardController`. The wallboard controller is found at `Controller>WallboardController.cs`.

### Acceptance Criteria
- PostCensorService is registered with the service container.
- PostCensorService is dependancy injected into the WallboardController.
- The CensorPost method is being used to censor posts before being added into the database.


## Challenge 3 - Finish the implementation of the CustomFilterCollection
### Description
Inside the Wallboard Controller `GetPosts` method in `Controllers>WallboardController.cs` a custom extension with is being used to filter the posts being returned. The method is called `CustomerFilterCollection`. If you look at the implementation of the method, you will see it takes an `IQueryable` and a `Expression<Func<T, bool>>` predicate. Finish the implementation by using the predicate to filter the posts, and return the filtered collection.

### Acceptance Criteria
- `CustomerFilterCollection` imlementation is completed.
- Wallboard controller `GetPosts` method is filtering posts using the predicate passed to `CustomerFilterCollection`
