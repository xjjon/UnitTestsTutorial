using NUnit.Framework;

namespace Editor.Tests
{
    public class HealthMonoBehaviourTest
    {
        [Test]
        public void RemoveHealthTest()
        {
            HealthMonoBehaviour healthMonoBehaviour = new HealthMonoBehaviour();
            healthMonoBehaviour.RemoveHealth(5);
        
            Assert.AreEqual(5, healthMonoBehaviour.Health);
        }
    }
}