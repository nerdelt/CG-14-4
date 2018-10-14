using System;
using Xunit;
using UserTimer;
using System.Collections.Generic;
using System.Timers;


namespace UserTimer.UnitTests
{
    public class TimerSetTests
    {
        [Fact]
        public void UserInputs_CorrectTime()
        {
            //arrange
            var TimerSet = new TimerSet();
            var userInput = "00:00:25";

            //act
            TimerSet.SetTimer(userInput);
            var parsedTime = TimerSet.ParsedTime;

            //assert
            Assert.Equal(TimeSpan.Parse("00:00:25"), parsedTime);

        }
        [Fact]
        public void UserInput_IsBlank()
        {
            //arrange
            var TimerSet = new TimerSet();
            var userInput = "";

            //act
            //assert
            Assert.Throws<FormatException>(() =>  TimerSet.SetTimer(userInput));
        }

        [Fact]
        public void UserInput_IsFalse()
        {
            var TimerSet = new TimerSet();
            var userInput = "??:)):00";

            Assert.Throws<FormatException>(() => TimerSet.SetTimer(userInput));
        }
    }
}
