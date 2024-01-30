Run `dotnet build .\A\A.fsproj`. Either Release or Debug mode is fine -- behavior hinges on the `Optimize` property.

You will see:

```
C:\**\A\A.fs(6,9): error FS0074: The type referenced through 'C.Foo' is defined in an assembly that is not referenced. You must add a reference to assembly 'C'. [C:\**\A\A.fsproj]
```

Change `Optimize` to `false` in `Directory.Build.props`. Now the build succeeds without error.
