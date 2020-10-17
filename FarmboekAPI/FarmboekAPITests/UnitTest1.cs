using Xunit;
using System;
using FluentAssertions;
using Microsoft.AspNetCore.Identity;
using Sodium;
using Xunit;
using Microsoft.Extensions.Options;
using ScottBrady91.AspNetCore.Identity;
using Xunit.Abstractions;

namespace FarmboekAPITests
{
    public class UnitTest1
    {

        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output) {
            this.output = output;
        }


        [Fact]
        public void HashPassword_WithDefaultSettings_ExpectVerifiableHash()
        {
            var password = "ABCDEfghijklMNOP";

            var hasher = new Argon2PasswordHasher<string>();
            var hashedPassword = hasher.HashPassword("", password);
            output.WriteLine(hashedPassword);

            //this will produce a 32 byte hash
            var hash = PasswordHash.ScryptHashString(password);

            PasswordHash.ArgonHashStringVerify(hashedPassword, password).Should().BeTrue();
        }
    }
}
