using FluentAssertions;
using Xunit;

namespace BikeDistributor.Domain
{
    public class OrderTest
    {
        private static readonly Bike Defy = new Bike("Giant", "Defy 1", Bike.OneThousand);
        private static readonly Bike Elite = new Bike("Specialized", "Venge Elite", Bike.TwoThousand);
        private static readonly Bike DuraAce = new Bike("Specialized", "S-Works Venge Dura-Ace", Bike.FiveThousand);

        [Fact]
        public void ReceiptOneDefy()
        {
			//Arrange
            var order = new Order(1, "Anywhere Bike Shop");
            order.AddLine(new OrderLine(Defy, 1));

            //Act
            var receipt = order.Receipt();

            //Assert
            receipt.Should().Be(ResultStatementOneDefy);
        }

        private const string ResultStatementOneDefy = @"Order Receipt for Anywhere Bike Shop
	1 x Giant Defy 1 = $1,000.00
Sub-Total: $1,000.00
Tax: $72.50
Total: $1,072.50";

        [Fact]
        public void ReceiptOneElite()
        {
            //Arrange
            var order = new Order(1, "Anywhere Bike Shop");
            order.AddLine(new OrderLine(Elite, 1));

            //Act
            var receipt = order.Receipt();

            //Assert
            receipt.Should().Be(ResultStatementOneElite);
        }

        private const string ResultStatementOneElite = @"Order Receipt for Anywhere Bike Shop
	1 x Specialized Venge Elite = $2,000.00
Sub-Total: $2,000.00
Tax: $145.00
Total: $2,145.00";

        [Fact]
        public void ReceiptOneDuraAce()
        {
            //Arrange
            var order = new Order(1, "Anywhere Bike Shop");
            order.AddLine(new OrderLine(DuraAce, 1));

            //Act
            var receipt = order.Receipt();

            //Assert
            receipt.Should().Be(ResultStatementOneDuraAce);
        }

        private const string ResultStatementOneDuraAce = @"Order Receipt for Anywhere Bike Shop
	1 x Specialized S-Works Venge Dura-Ace = $5,000.00
Sub-Total: $5,000.00
Tax: $362.50
Total: $5,362.50";

        [Fact]
        public void HtmlReceiptOneDefy()
        {
            //Arrange
            var order = new Order(1, "Anywhere Bike Shop");
            order.AddLine(new OrderLine(Defy, 1));

            //Act
            var receipt = order.HtmlReceipt();

            //Assert
            receipt.Should().Be(HtmlResultStatementOneDefy);
        }

        private const string HtmlResultStatementOneDefy = "<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Giant Defy 1 = $1,000.00</li></ul><h3>Sub-Total: $1,000.00</h3><h3>Tax: $72.50</h3><h2>Total: $1,072.50</h2></body></html>";

        [Fact]
        public void HtmlReceiptOneElite()
        {
            //Arrange
            var order = new Order(1, "Anywhere Bike Shop");
            order.AddLine(new OrderLine(Elite, 1));

            //Act
            var receipt = order.HtmlReceipt();

            //Assert
            receipt.Should().Be(HtmlResultStatementOneElite);
        }

        private const string HtmlResultStatementOneElite = "<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Specialized Venge Elite = $2,000.00</li></ul><h3>Sub-Total: $2,000.00</h3><h3>Tax: $145.00</h3><h2>Total: $2,145.00</h2></body></html>";

        [Fact]
        public void HtmlReceiptOneDuraAce()
        {
            //Arrange
            var order = new Order(1, "Anywhere Bike Shop");
            order.AddLine(new OrderLine(DuraAce, 1));

            //Act
            var receipt = order.HtmlReceipt();

            //Assert
            receipt.Should().Be(HtmlResultStatementOneDuraAce);
        }

        private const string HtmlResultStatementOneDuraAce = "<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Specialized S-Works Venge Dura-Ace = $5,000.00</li></ul><h3>Sub-Total: $5,000.00</h3><h3>Tax: $362.50</h3><h2>Total: $5,362.50</h2></body></html>";
    }
}


