﻿namespace eShop.ClientApp.UnitTests;

public class OrdersServiceTests
{
    [Fact]
    public async Task GetFakeOrderTest()
    {
        var ordersMockService = new OrderMockService();
        var order = await ordersMockService.GetOrderAsync(1, GlobalSetting.Instance.AuthToken);

        Assert.NotNull(order);
    }

    [Fact]
    public async Task GetFakeOrdersTest()
    {
        var ordersMockService = new OrderMockService();
        var result = await ordersMockService.GetOrdersAsync(GlobalSetting.Instance.AuthToken);

        Assert.NotEmpty(result);
    }
}
