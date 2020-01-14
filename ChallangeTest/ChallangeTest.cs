using System;
using Xunit;
using Challange;
using System.Collections;

namespace ChallangeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Your_Name()
        {
            Assert.Equal("Huda",YourName.PrintName("Huda"));
        }

        [Fact]
        public void Days_Next_Birthday()
        {
            Assert.Equal(81,DaysToNextBirthday.difference("1996/08/23"));
        }

        [Fact]
        public void String_Lenght()
        {
            Assert.Equal(10,StringLength.CountString("Hello World"));
        }

        [Fact]
        public void Subtitution_Test()
        {
            Assert.Equal("Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.",Subtitutions.Substitution("Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy."));
        }

        [Fact]
        public void EvenOdd_Test()
        {
            Assert.True(EvenOdd.IsEven(8));
            Assert.False(EvenOdd.IsOdd(4));
        }

        [Fact]
        public void Grade_Test()
        {
            Assert.Equal("A",GradeClass.Grade(90));
            Assert.Equal("B",GradeClass.Grade(81));
        }

        [Fact]
        public void TempConv_Test()
        {   
            //TRUE
            Assert.Equal(32,TemperatureConverter.CelciusToFahrenheit(0));
            Assert.Equal(10,TemperatureConverter.FahrenheitToCelcius(50));
            Assert.Equal(373.15,TemperatureConverter.CelciusToKelvin(100));

            // //FALSE
            // Assert.Equal(101.85,TemperatureConverter.KelvinToCelcius(375));
            // Assert.Equal(215.33,TemperatureConverter.KelvinToFahrenheit(375));
            // Assert.Equal(262.039,TemperatureConverter.FahrenheitToKelvin(12));
        }

        [Fact]
        public void LeapYear_Test()
        {
            Assert.True(LeapYear.IsLeapYear(2020));
        }

        [Fact]
        public void TimeZone_Test()
        {
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var london = Tuple.Create("London", 0);
            var cairo = Tuple.Create("Cairo", 2);
            var denver = Tuple.Create("Denver", -6);
            var chicago = Tuple.Create("Chicago", -5);

            Assert.Equal("Jakarta 7 hours ahead London",Timezone.TimezoneDiff(jakarta,london));
        }

         [Fact]
        public void Calc_Test()
        {
            Assert.Equal(7,Calculator.Sum(1,6));
        }

        [Fact]
        public void SumArg_Test()
        {
            Assert.Equal(17,SumArguments.SumArgument(1,2,3,11));
        }

        [Fact]
        public void ToUpper_Test()
        {
            Assert.Equal("HALO",ToUpperCase.ToUpper("halo"));
        }

        [Fact]
        public void CountWords_Test()
        {
            Assert.Equal(2,CountWord.CountWords("Hello World"));
        }

        [Fact]
        public void Palindrom_Test()
        {
            Assert.True(PalindromeDetector.IsPalindrome("ibu ratna antar ubi"));
        }

        [Fact]
        public void Mirror_Test()
        {
            Assert.Equal("--vvvv--",MirrorString.Mirror("--vv"));
        }

        [Fact]
        public void Fruti_Test()
        {
            string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };

            Assert.Equal(0,FruitFinder.IndexFinder(fruits, "Jeruk"));
        }

        [Fact]
        public void FooBar_Test()
        {
            var expected = new ArrayList();
            for(int i=0; i<1000; i++){
                if(i%5 == 0){
                    if(i%20 == 0){
                        if(i%100 == 0)
                            expected.Add("Baz");

                        else
                            expected.Add("Bar");
                    }

                    else
                        expected.Add("Foo");
                }

                else
                    expected.Add(i);
            }
            Assert.Equal(expected,FooBarBaz.FooBar());
        }

        [Fact]
        public void FindMinMax_Test()
        {
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
            Assert.Equal(330, FindMinMaxAvg.FindMax(numbers));
            Assert.Equal(-65, FindMinMaxAvg.FindMin(numbers));
            //Assert.Equal(52.16, FindMinMaxAvg.FindAverage(numbers));
        }

        [Fact]
        public void Sort_Test()
        {
            int[] expected = {-65, -4, 2, 4, 12, 19, 40, 54, 54, 88, 92, 330};
            int[] raw = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};

            Assert.Equal(expected,Sorter.hasil(raw));
        }

        [Fact]
        public void tes_class_obj()
        {
            string expected = "Indomie Goreng (Rp 2800)";
            Item.name = "Indomie Goreng";
            Item.price = 3500;
            Item.onSale = true;

            Assert.Equal(expected, Item.testPrint());
        }

        

    }
}
