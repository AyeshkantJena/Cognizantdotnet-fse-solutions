using Moq;
using NUnit.Framework;
using CustomerCommLib; // Reference to your main project

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mockMailSender;
        private CustomerCommLib.CustomerComm _customerComm; // Fully qualify the type to avoid ambiguity

        [OneTimeSetUp]
        public void Init()
        {
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender
                .Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);  // Simulate successful email sending

            _customerComm = new CustomerCommLib.CustomerComm(_mockMailSender.Object); // Fully qualify the type
        }

        [Test]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            var result = _customerComm.SendMailToCustomer();
            Assert.That(result, Is.True);
        }
    }
}
