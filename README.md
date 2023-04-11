https://www.codewars.com/kata/52755006cc238fcae70000ed/csharp

# Buildinstruction for SmcdXmasTree.API

## Rider

* Open the solution and select the Solution View in Rider
* Right click the project SmcdXmasTree.API and select "Debug"
* In the Debug Window on the Console Log Tab, the service URL is displayed
* Open http://localhost:5202/swagger/index.html (take the port from the Debug window)


# CLI
* start API controller in watch mode with
    ```bash
    dotnet watch --project=SmcdXmasTree.API.csproj run
    ```
    important: to use the launchsetting of the API project, this command has to be executed within the project's subdirectory
* run the tests in watch mode
    ```bash
    dotnet watch --project=SmcdXmasTree.API.Tests/SmcdXmasTree.API.Tests.csproj test
    ```
