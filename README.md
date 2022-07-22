The first commit of this "hello world" repo was a 2022-era use of `dotnet.exe` on the command line for build and test. For that version, `dotnet.exe test` ran all 
the tests on the command line. The solution and two projects would load into Rider for execution just fine.

The end product of seven or so commits is the same hello world app/test migration to a [Nx](https://nx.dev/) build system and directory structure.  There are still 
two projects that load into Rider, but there's no solution by default.  The [nx-dotnet](https://github.com/nx-dotnet/nx-dotnet) plugin is used to do seamless 
interop between Nx and the dotnet.exe cli which is still used behind the scenes.

# Pre-reqs

```
npm install
```

# Compile

```
npx nx build my-app
```

# Run tests

```
npx nx test my-app-test
```
