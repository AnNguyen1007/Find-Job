﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace FindJob.Pages
{
    public class Index_Tests : FindJobWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
