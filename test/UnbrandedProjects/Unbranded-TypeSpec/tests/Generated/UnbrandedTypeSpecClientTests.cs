// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using NUnit.Framework;
using UnbrandedTypeSpec;

namespace UnbrandedTypeSpec.Tests
{
    public partial class UnbrandedTypeSpecClientTests
    {
        [Test]
        public void SmokeTest()
        {
            Uri endpoint = new Uri("https://my-service.com");
            KeyCredential credential = new KeyCredential(Environment.GetEnvironmentVariable("UnbrandedTypeSpecClient_KEY"));
            UnbrandedTypeSpecClient client = new UnbrandedTypeSpecClient(endpoint, credential);
            Assert.IsNotNull(client);
        }
    }
}
