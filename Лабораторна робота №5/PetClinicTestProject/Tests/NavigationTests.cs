using NUnit.Framework;

[TestFixture]
public class NavigationTests:TestBase {
  [Test]
  public void ownerTabTestCase() {
    pages.menu.openNewOwnerPage();
  }
  [Test]
  public void veterinarianTabTestCase() {
    pages.menu.openNewVeterinarianPage();
  }
  [Test]
  public void petTypeTabTestCase() {
    pages.menu.openPetTypePage();
  }
  [Test]
  public void specialtiesTabTestCase() {
    pages.menu.openSpecialtyPage();
  }
}
