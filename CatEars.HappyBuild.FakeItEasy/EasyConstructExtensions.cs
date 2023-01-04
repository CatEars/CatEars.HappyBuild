﻿using FakeItEasy.Sdk;

namespace CatEars.HappyBuild.FakeItEasy;

public static class EasyConstructExtensions
{
    public static BuildScope AutoScope(this Easy.BuildInstance _)
    {
        var buildContext = new BuildContext(new BuildContext.Options()
        {
            MockFactoryMethod = Create.Fake,
            RegistrationMode = RegistrationMode.Dynamic
        });
        return buildContext.Scope();
    }
}