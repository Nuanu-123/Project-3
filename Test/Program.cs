using MarsFramework.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            //Share Skill Page
            [Test]
            public void EnterShareSkillTest()

            {
                test = extent.StartTest("Enter Share Skill");
                ShareSkill shareSkillPage = new ShareSkill();
                shareSkillPage.EnterShareSkill();
                shareSkillPage.VerifyEnterShareSkill();
            }
            [Test]
            public void Managelistingpage()

            {
                test = extent.StartTest("View Listing");
                ManageListings manageListings = new ManageListings();
                manageListings.ActiveToggleWorking();
            }

           [Test]
            public void AddProfileDetails()
            {
                test = extent.StartTest("Add Profile");
                Profile profile = new Profile();
                profile.EditProfile();
                profile.VerifyEditProfile();
            }


            [Test]
            public void DeleteListingTest()
            {
                test = extent.StartTest("Delete Listing");
                ManageListings deletelisting = new ManageListings();
                deletelisting.DeleteListing();
                deletelisting.VerifyDeleteListing();
            }


        }

    }
}