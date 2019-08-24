﻿using System;
using CliFx.Services;
using FluentAssertions;
using NUnit.Framework;

namespace CliFx.Tests.Services
{
    [TestFixture]
    public class SystemConsoleTests
    {
        // Test that it correctly wraps around System.Console
        [Test]
        public void All_Smoke_Test()
        {
            // Arrange
            var console = new SystemConsole();

            console.ResetColor();
            console.ForegroundColor = ConsoleColor.DarkMagenta;
            console.BackgroundColor = ConsoleColor.DarkMagenta;

            // Assert
            console.Input.Should().BeSameAs(Console.In);
            console.IsInputRedirected.Should().Be(Console.IsInputRedirected);
            console.Output.Should().BeSameAs(Console.Out);
            console.IsOutputRedirected.Should().Be(Console.IsOutputRedirected);
            console.Error.Should().BeSameAs(Console.Error);
            console.IsErrorRedirected.Should().Be(Console.IsErrorRedirected);
            console.ForegroundColor.Should().Be(Console.ForegroundColor);
            console.BackgroundColor.Should().Be(Console.BackgroundColor);
        }
    }
}