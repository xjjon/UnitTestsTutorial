using NUnit.Framework;

namespace Editor.Tests
{
    public class HealthComponentTest
    {
        private const int StartingHealth = 10;
        private HealthComponent _healthComponent;

        [SetUp]
        public void SetUp()
        {
            _healthComponent = new HealthComponent(StartingHealth);
        }
        
        [Test]
        public void RemoveHealthTest()
        {
            _healthComponent.RemoveHealth(5);
            Assert.AreEqual(5, _healthComponent.Health);
        }

        [Test]
        public void IsDeadTest()
        {
            _healthComponent = new HealthComponent(0);
            Assert.IsTrue(_healthComponent.IsDead);
        }
        
        [Test]
        public void IsNotDeadTest()
        {
            Assert.IsFalse(_healthComponent.IsDead);
        }
    }
}