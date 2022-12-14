// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AmazonProject.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Homepage", Description="\tHomepage for amazon", SourceFile="Features\\Homepage.feature", SourceLine=0)]
    public partial class HomepageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Homepage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Homepage", "\tHomepage for amazon", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
 #line hidden
#line 5
 testRunner.Given("Navigate to amazon url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void SearchForDifferentItems(string searchText, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Tag1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Search Text", searchText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for different items", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
 this.FeatureBackground();
#line hidden
#line 9
 testRunner.When(string.Format("Search for a text {0}", searchText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then("user click on the Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And(string.Format("user should be able to see the reuslts for the  {0}", searchText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search for different items, Badminton", new string[] {
                "Tag1"}, SourceLine=14)]
        public void SearchForDifferentItems_Badminton()
        {
#line 8
this.SearchForDifferentItems("Badminton", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search for different items, Mobile", new string[] {
                "Tag1"}, SourceLine=14)]
        public void SearchForDifferentItems_Mobile()
        {
#line 8
this.SearchForDifferentItems("Mobile", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search for different items, Wardrobe", new string[] {
                "Tag1"}, SourceLine=14)]
        public void SearchForDifferentItems_Wardrobe()
        {
#line 8
this.SearchForDifferentItems("Wardrobe", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search for different items, Clothes", new string[] {
                "Tag1"}, SourceLine=14)]
        public void SearchForDifferentItems_Clothes()
        {
#line 8
this.SearchForDifferentItems("Clothes", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search for different items, Toys", new string[] {
                "Tag1"}, SourceLine=14)]
        public void SearchForDifferentItems_Toys()
        {
#line 8
this.SearchForDifferentItems("Toys", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search for different items, Camera", new string[] {
                "Tag1"}, SourceLine=14)]
        public void SearchForDifferentItems_Camera()
        {
#line 8
this.SearchForDifferentItems("Camera", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search for different items, jewellery", new string[] {
                "Tag1"}, SourceLine=14)]
        public void SearchForDifferentItems_Jewellery()
        {
#line 8
this.SearchForDifferentItems("jewellery", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search for different items, Laptop", new string[] {
                "Tag1"}, SourceLine=14)]
        public void SearchForDifferentItems_Laptop()
        {
#line 8
this.SearchForDifferentItems("Laptop", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search for different items, Basketball", new string[] {
                "Tag1"}, SourceLine=14)]
        public void SearchForDifferentItems_Basketball()
        {
#line 8
this.SearchForDifferentItems("Basketball", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Navigate through all the values present in Search dropdown", new string[] {
                "Tag2"}, SourceLine=26)]
        public void NavigateThroughAllTheValuesPresentInSearchDropdown()
        {
            string[] tagsOfScenario = new string[] {
                    "Tag2"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate through all the values present in Search dropdown", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
 this.FeatureBackground();
#line hidden
#line 28
 testRunner.Then("user should be able to select each value present in search dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Navigate to Amazon Pay and verify it contains the various optins or not", new string[] {
                "Tag2"}, SourceLine=30)]
        public void NavigateToAmazonPayAndVerifyItContainsTheVariousOptinsOrNot()
        {
            string[] tagsOfScenario = new string[] {
                    "Tag2"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Amazon Pay and verify it contains the various optins or not", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Toolbar Values"});
                table1.AddRow(new string[] {
                            "Best Sellers"});
                table1.AddRow(new string[] {
                            "Today\'s Deals"});
                table1.AddRow(new string[] {
                            "Mobiles"});
                table1.AddRow(new string[] {
                            "Customer Service"});
                table1.AddRow(new string[] {
                            "Books"});
                table1.AddRow(new string[] {
                            "Electronics"});
                table1.AddRow(new string[] {
                            "Amazon Pay"});
#line 32
 testRunner.Given("amazon homepage toolbar contains the following values", ((string)(null)), table1, "Given ");
#line hidden
#line 41
 testRunner.When("user click on AmazonPay", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Header Values"});
                table2.AddRow(new string[] {
                            "Recharges, Bill Payments"});
                table2.AddRow(new string[] {
                            "Travel and insurance"});
                table2.AddRow(new string[] {
                            "Rewards"});
                table2.AddRow(new string[] {
                            "Gift Cards & Vouchers"});
#line 42
 testRunner.Then("user should see be able the following header values", ((string)(null)), table2, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
