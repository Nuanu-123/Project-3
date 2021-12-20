using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            
            //Share Skill Page - Enter a skill and verify
            [Test]
            public void EnterShareSkillTest()

            {
                test = extent.StartTest("Enter Share Skill");
                ShareSkill shareSkillPage = new ShareSkill();
                shareSkillPage.EnterShareSkill();
                shareSkillPage.VerifyEnterShareSkill();
            }

            //Checking the working of active toggle button
            [Test]
            public void Managelistingpage()

            {
                test = extent.StartTest("View Listing");
                ManageListings manageListings = new ManageListings();
                manageListings.ActiveToggleWorking();
            }

            //Adding the profile details
            [Test]
            public void AddProfileDetails()
            {
                test = extent.StartTest("Add Profile");
                Profile profile = new Profile();
                profile.EditProfile();
                profile.VerifyEditProfile();
            }

            //Delete the listing added in EnterShareSkill test
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