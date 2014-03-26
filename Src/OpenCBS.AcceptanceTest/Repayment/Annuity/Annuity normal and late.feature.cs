﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OpenCBS.AcceptanceTest.Repayment.Annuity
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Annuity normal and late")]
    public partial class AnnuityNormalAndLateFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Annuity normal and late.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Annuity normal and late", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Simple early repayment")]
        public virtual void SimpleEarlyRepayment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simple early repayment", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table1.AddRow(new string[] {
                        "USE_CENTS",
                        "Yes"});
            table1.AddRow(new string[] {
                        "INCREMENTAL_DURING_DAYOFFS",
                        "Yes"});
            table1.AddRow(new string[] {
                        "ACCOUNTING_PROCESS",
                        "Accrual"});
            table1.AddRow(new string[] {
                        "USE_DAILY_ACCRUAL_OF_PENALTY",
                        "False"});
#line 5
    testRunner.Given("these settings", ((string)(null)), table1, "Given ");
#line 11
    testRunner.And("the \"ANNUITY\" loan product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table2.AddRow(new string[] {
                        "Installments",
                        "12"});
            table2.AddRow(new string[] {
                        "Amount",
                        "45000"});
            table2.AddRow(new string[] {
                        "Interest rate",
                        "42"});
            table2.AddRow(new string[] {
                        "Grace period",
                        "0"});
            table2.AddRow(new string[] {
                        "Rounding",
                        "End"});
            table2.AddRow(new string[] {
                        "Start date",
                        "25.03.2014"});
            table2.AddRow(new string[] {
                        "First installment date",
                        "25.04.2014"});
#line 13
    testRunner.When("I create a loan", ((string)(null)), table2, "When ");
#line 22
    testRunner.And("I set line of credit limit to 1000000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
    testRunner.And("I disburse on 25.03.2014", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Expected date",
                        "Expected interest",
                        "Expected principal",
                        "Expected total",
                        "Olb",
                        "Paid principal",
                        "Paid interest"});
            table3.AddRow(new string[] {
                        "1",
                        "25.04.2014",
                        "1575,00",
                        "3081,78",
                        "4656,78",
                        "45000,00",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "2",
                        "26.05.2014",
                        "1467,14",
                        "3189,64",
                        "4656,78",
                        "41918,22",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "3",
                        "25.06.2014",
                        "1355,50",
                        "3301,28",
                        "4656,78",
                        "38728,58",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "4",
                        "25.07.2014",
                        "1239,96",
                        "3416,82",
                        "4656,78",
                        "35427,30",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "5",
                        "25.08.2014",
                        "1120,37",
                        "3536,41",
                        "4656,78",
                        "32010,48",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "6",
                        "25.09.2014",
                        "996,59",
                        "3660,19",
                        "4656,78",
                        "28474,07",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "7",
                        "27.10.2014",
                        "868,49",
                        "3788,29",
                        "4656,78",
                        "24813,88",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "8",
                        "25.11.2014",
                        "735,90",
                        "3920,88",
                        "4656,78",
                        "21025,59",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "9",
                        "25.12.2014",
                        "598,66",
                        "4058,12",
                        "4656,78",
                        "17104,71",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "10",
                        "26.01.2015",
                        "456,63",
                        "4200,15",
                        "4656,78",
                        "13046,59",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "11",
                        "25.02.2015",
                        "309,63",
                        "4347,15",
                        "4656,78",
                        "8846,44",
                        "0",
                        "0"});
            table3.AddRow(new string[] {
                        "12",
                        "25.03.2015",
                        "157,48",
                        "4499,29",
                        "4656,77",
                        "4499,29",
                        "0",
                        "0"});
#line 25
 testRunner.Then("the schedule is", ((string)(null)), table3, "Then ");
#line 41
    testRunner.When("I repay 4656,78 on 25.04.2014", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Expected date",
                        "Expected interest",
                        "Expected principal",
                        "Expected total",
                        "Olb",
                        "Paid principal",
                        "Paid interest"});
            table4.AddRow(new string[] {
                        "1",
                        "25.04.2014",
                        "1575,00",
                        "3081,78",
                        "0",
                        "45000,00",
                        "3081,78",
                        "1575,00"});
            table4.AddRow(new string[] {
                        "2",
                        "26.05.2014",
                        "1467,14",
                        "3189,64",
                        "4656,78",
                        "41918,22",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "3",
                        "25.06.2014",
                        "1355,50",
                        "3301,28",
                        "4656,78",
                        "38728,58",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "4",
                        "25.07.2014",
                        "1239,96",
                        "3416,82",
                        "4656,78",
                        "35427,30",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "5",
                        "25.08.2014",
                        "1120,37",
                        "3536,41",
                        "4656,78",
                        "32010,48",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "6",
                        "25.09.2014",
                        "996,59",
                        "3660,19",
                        "4656,78",
                        "28474,07",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "7",
                        "27.10.2014",
                        "868,49",
                        "3788,29",
                        "4656,78",
                        "24813,88",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "8",
                        "25.11.2014",
                        "735,90",
                        "3920,88",
                        "4656,78",
                        "21025,59",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "9",
                        "25.12.2014",
                        "598,66",
                        "4058,12",
                        "4656,78",
                        "17104,71",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "10",
                        "26.01.2015",
                        "456,63",
                        "4200,15",
                        "4656,78",
                        "13046,59",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "11",
                        "25.02.2015",
                        "309,63",
                        "4347,15",
                        "4656,78",
                        "8846,44",
                        "0",
                        "0"});
            table4.AddRow(new string[] {
                        "12",
                        "25.03.2015",
                        "157,48",
                        "4499,29",
                        "4656,77",
                        "4499,29",
                        "0",
                        "0"});
#line 43
 testRunner.Then("the schedule is", ((string)(null)), table4, "Then ");
#line 59
    testRunner.When("I repay 4656,78 on 20.05.2014", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Expected date",
                        "Expected interest",
                        "Expected principal",
                        "Expected total",
                        "Olb",
                        "Paid principal",
                        "Paid interest"});
            table5.AddRow(new string[] {
                        "1",
                        "25.04.2014",
                        "1575,00",
                        "3081,78",
                        "0",
                        "45000,00",
                        "3081,78",
                        "1575,00"});
            table5.AddRow(new string[] {
                        "2",
                        "26.05.2014",
                        "1467,14",
                        "3189,64",
                        "0",
                        "41918,22",
                        "3189,64",
                        "1467,14"});
            table5.AddRow(new string[] {
                        "3",
                        "25.06.2014",
                        "1355,50",
                        "3301,28",
                        "4656,78",
                        "38728,58",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "4",
                        "25.07.2014",
                        "1239,96",
                        "3416,82",
                        "4656,78",
                        "35427,30",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "5",
                        "25.08.2014",
                        "1120,37",
                        "3536,41",
                        "4656,78",
                        "32010,48",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "6",
                        "25.09.2014",
                        "996,59",
                        "3660,19",
                        "4656,78",
                        "28474,07",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "7",
                        "27.10.2014",
                        "868,49",
                        "3788,29",
                        "4656,78",
                        "24813,88",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "8",
                        "25.11.2014",
                        "735,90",
                        "3920,88",
                        "4656,78",
                        "21025,59",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "9",
                        "25.12.2014",
                        "598,66",
                        "4058,12",
                        "4656,78",
                        "17104,71",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "10",
                        "26.01.2015",
                        "456,63",
                        "4200,15",
                        "4656,78",
                        "13046,59",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "11",
                        "25.02.2015",
                        "309,63",
                        "4347,15",
                        "4656,78",
                        "8846,44",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "12",
                        "25.03.2015",
                        "157,48",
                        "4499,29",
                        "4656,77",
                        "4499,29",
                        "0",
                        "0"});
#line 61
 testRunner.Then("the schedule is", ((string)(null)), table5, "Then ");
#line 91
 testRunner.When("I accrue_penalties 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.When("I repay 10000 on 25.06.2014", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Expected date",
                        "Expected interest",
                        "Expected principal",
                        "Expected total",
                        "Olb",
                        "Paid principal",
                        "Paid interest"});
            table6.AddRow(new string[] {
                        "1",
                        "25.04.2014",
                        "1575,00",
                        "3081,78",
                        "0",
                        "45000,00",
                        "3081,78",
                        "1575,00"});
            table6.AddRow(new string[] {
                        "2",
                        "26.05.2014",
                        "1467,14",
                        "3189,64",
                        "0",
                        "41918,22",
                        "3189,64",
                        "1467,14"});
            table6.AddRow(new string[] {
                        "3",
                        "25.06.2014",
                        "1355,50",
                        "3301,28",
                        "0",
                        "38728,58",
                        "3301,28",
                        "1355,50"});
            table6.AddRow(new string[] {
                        "4",
                        "25.07.2014",
                        "1239,96",
                        "3416,82",
                        "0",
                        "35427,30",
                        "3416,82",
                        "1239,96"});
            table6.AddRow(new string[] {
                        "5",
                        "25.08.2014",
                        "1120,37",
                        "3536,41",
                        "3970,34",
                        "32010,48",
                        "0",
                        "686,44"});
            table6.AddRow(new string[] {
                        "6",
                        "25.09.2014",
                        "996,59",
                        "3660,19",
                        "4656,78",
                        "28474,07",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "7",
                        "27.10.2014",
                        "868,49",
                        "3788,29",
                        "4656,78",
                        "24813,88",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "8",
                        "25.11.2014",
                        "735,90",
                        "3920,88",
                        "4656,78",
                        "21025,59",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "9",
                        "25.12.2014",
                        "598,66",
                        "4058,12",
                        "4656,78",
                        "17104,71",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "10",
                        "26.01.2015",
                        "456,63",
                        "4200,15",
                        "4656,78",
                        "13046,59",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "11",
                        "25.02.2015",
                        "309,63",
                        "4347,15",
                        "4656,78",
                        "8846,44",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "12",
                        "25.03.2015",
                        "157,48",
                        "4499,29",
                        "4656,77",
                        "4499,29",
                        "0",
                        "0"});
#line 103
 testRunner.Then("the schedule is", ((string)(null)), table6, "Then ");
#line 124
 testRunner.When("I accrue_penalties 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.When("I repay 10000 on 20.08.2014 with 1000 for commission with 300 for penalties with " +
                    "3000 for interest", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Expected date",
                        "Expected interest",
                        "Expected principal",
                        "Expected total",
                        "Olb",
                        "Paid principal",
                        "Paid interest"});
            table7.AddRow(new string[] {
                        "1",
                        "25.04.2014",
                        "1575,00",
                        "3081,78",
                        "0",
                        "45000,00",
                        "3081,78",
                        "1575,00"});
            table7.AddRow(new string[] {
                        "2",
                        "26.05.2014",
                        "1467,14",
                        "3189,64",
                        "0",
                        "41918,22",
                        "3189,64",
                        "1467,14"});
            table7.AddRow(new string[] {
                        "3",
                        "25.06.2014",
                        "1355,50",
                        "3301,28",
                        "0",
                        "38728,58",
                        "3301,28",
                        "1355,50"});
            table7.AddRow(new string[] {
                        "4",
                        "25.07.2014",
                        "1239,96",
                        "3416,82",
                        "0",
                        "35427,30",
                        "3416,82",
                        "1239,96"});
            table7.AddRow(new string[] {
                        "5",
                        "25.08.2014",
                        "1120,37",
                        "3536,41",
                        "0",
                        "32010,48",
                        "3536,41",
                        "1120,37"});
            table7.AddRow(new string[] {
                        "6",
                        "25.09.2014",
                        "996,59",
                        "3660,19",
                        "1496,60",
                        "28474,07",
                        "2163,59",
                        "996,59"});
            table7.AddRow(new string[] {
                        "7",
                        "27.10.2014",
                        "868,49",
                        "3788,29",
                        "3788,29",
                        "24813,88",
                        "0",
                        "868,49"});
            table7.AddRow(new string[] {
                        "8",
                        "25.11.2014",
                        "735,90",
                        "3920,88",
                        "3955,79",
                        "21025,59",
                        "0",
                        "700,99"});
            table7.AddRow(new string[] {
                        "9",
                        "25.12.2014",
                        "598,66",
                        "4058,12",
                        "4656,78",
                        "17104,71",
                        "0",
                        "0"});
            table7.AddRow(new string[] {
                        "10",
                        "26.01.2015",
                        "456,63",
                        "4200,15",
                        "4656,78",
                        "13046,59",
                        "0",
                        "0"});
            table7.AddRow(new string[] {
                        "11",
                        "25.02.2015",
                        "309,63",
                        "4347,15",
                        "4656,78",
                        "8846,44",
                        "0",
                        "0"});
            table7.AddRow(new string[] {
                        "12",
                        "25.03.2015",
                        "157,48",
                        "4499,29",
                        "4656,77",
                        "4499,29",
                        "0",
                        "0"});
#line 137
 testRunner.Then("the schedule is", ((string)(null)), table7, "Then ");
#line 159
 testRunner.When("I accrue_penalties 500", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 171
 testRunner.When("I repay 10000 on 27.01.2015", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Expected date",
                        "Expected interest",
                        "Expected principal",
                        "Expected total",
                        "Olb",
                        "Paid principal",
                        "Paid interest"});
            table8.AddRow(new string[] {
                        "1",
                        "25.04.2014",
                        "1575,00",
                        "3081,78",
                        "0",
                        "45000,00",
                        "3081,78",
                        "1575,00"});
            table8.AddRow(new string[] {
                        "2",
                        "26.05.2014",
                        "1467,14",
                        "3189,64",
                        "0",
                        "41918,22",
                        "3189,64",
                        "1467,14"});
            table8.AddRow(new string[] {
                        "3",
                        "25.06.2014",
                        "1355,50",
                        "3301,28",
                        "0",
                        "38728,58",
                        "3301,28",
                        "1355,50"});
            table8.AddRow(new string[] {
                        "4",
                        "25.07.2014",
                        "1239,96",
                        "3416,82",
                        "0",
                        "35427,30",
                        "3416,82",
                        "1239,96"});
            table8.AddRow(new string[] {
                        "5",
                        "25.08.2014",
                        "1120,37",
                        "3536,41",
                        "0",
                        "32010,48",
                        "3536,41",
                        "1120,37"});
            table8.AddRow(new string[] {
                        "6",
                        "25.09.2014",
                        "996,59",
                        "3660,19",
                        "0",
                        "28474,07",
                        "3660,19",
                        "996,59"});
            table8.AddRow(new string[] {
                        "7",
                        "27.10.2014",
                        "868,49",
                        "3788,29",
                        "0",
                        "24813,88",
                        "3788,29",
                        "868,49"});
            table8.AddRow(new string[] {
                        "8",
                        "25.11.2014",
                        "735,90",
                        "3920,88",
                        "0",
                        "21025,59",
                        "3920,88",
                        "735,90"});
            table8.AddRow(new string[] {
                        "9",
                        "25.12.2014",
                        "598,66",
                        "4058,12",
                        "4397,46",
                        "17104,71",
                        "0",
                        "259,32"});
            table8.AddRow(new string[] {
                        "10",
                        "26.01.2015",
                        "456,63",
                        "4200,15",
                        "4656,78",
                        "13046,59",
                        "0",
                        "0"});
            table8.AddRow(new string[] {
                        "11",
                        "25.02.2015",
                        "309,63",
                        "4347,15",
                        "4656,78",
                        "8846,44",
                        "0",
                        "0"});
            table8.AddRow(new string[] {
                        "12",
                        "25.03.2015",
                        "157,48",
                        "4499,29",
                        "4656,77",
                        "4499,29",
                        "0",
                        "0"});
#line 173
 testRunner.Then("the schedule is", ((string)(null)), table8, "Then ");
#line 191
 testRunner.When("I repay 18367,79 on 30.01.2015", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Expected date",
                        "Expected interest",
                        "Expected principal",
                        "Expected total",
                        "Olb",
                        "Paid principal",
                        "Paid interest"});
            table9.AddRow(new string[] {
                        "1",
                        "25.04.2014",
                        "1575,00",
                        "3081,78",
                        "0",
                        "45000,00",
                        "3081,78",
                        "1575,00"});
            table9.AddRow(new string[] {
                        "2",
                        "26.05.2014",
                        "1467,14",
                        "3189,64",
                        "0",
                        "41918,22",
                        "3189,64",
                        "1467,14"});
            table9.AddRow(new string[] {
                        "3",
                        "25.06.2014",
                        "1355,50",
                        "3301,28",
                        "0",
                        "38728,58",
                        "3301,28",
                        "1355,50"});
            table9.AddRow(new string[] {
                        "4",
                        "25.07.2014",
                        "1239,96",
                        "3416,82",
                        "0",
                        "35427,30",
                        "3416,82",
                        "1239,96"});
            table9.AddRow(new string[] {
                        "5",
                        "25.08.2014",
                        "1120,37",
                        "3536,41",
                        "0",
                        "32010,48",
                        "3536,41",
                        "1120,37"});
            table9.AddRow(new string[] {
                        "6",
                        "25.09.2014",
                        "996,59",
                        "3660,19",
                        "0",
                        "28474,07",
                        "3660,19",
                        "996,59"});
            table9.AddRow(new string[] {
                        "7",
                        "27.10.2014",
                        "868,49",
                        "3788,29",
                        "0",
                        "24813,88",
                        "3788,29",
                        "868,49"});
            table9.AddRow(new string[] {
                        "8",
                        "25.11.2014",
                        "735,90",
                        "3920,88",
                        "0",
                        "21025,59",
                        "3920,88",
                        "735,90"});
            table9.AddRow(new string[] {
                        "9",
                        "25.12.2014",
                        "598,66",
                        "4058,12",
                        "0",
                        "17104,71",
                        "4058,12",
                        "598,66"});
            table9.AddRow(new string[] {
                        "10",
                        "26.01.2015",
                        "456,63",
                        "4200,15",
                        "0",
                        "13046,59",
                        "4200,15",
                        "456,63"});
            table9.AddRow(new string[] {
                        "11",
                        "25.02.2015",
                        "309,63",
                        "4347,15",
                        "0",
                        "8846,44",
                        "4347,15",
                        "309,63"});
            table9.AddRow(new string[] {
                        "12",
                        "25.03.2015",
                        "157,48",
                        "4499,29",
                        "0",
                        "4499,29",
                        "4499,29",
                        "157,48"});
#line 193
 testRunner.Then("the schedule is", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion