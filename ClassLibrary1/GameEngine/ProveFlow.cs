using GameOfLife;
using GameOfLife.Counters;
using GameOfLife.Loopers;
using GameOfLife.Outputs;
using GameOfLife.Rules;
using Moq;
using Xunit;

namespace ClassLibrary1.GameEngine
{
    public class ProveFlow
    {
        private readonly Mock<IDefineANeigbourCounter> counter;
        private readonly Mock<IDefineARulesEngine> rulesEngine;
        private readonly Mock<IDefineAnOutputter> outputter;
        private readonly Mock<IDefineLoopHandler> looperHandler;

        public ProveFlow()
        {
            counter = new Mock<IDefineANeigbourCounter>();
            rulesEngine = new Mock<IDefineARulesEngine>();
            outputter = new Mock<IDefineAnOutputter>();

            looperHandler = new Mock<IDefineLoopHandler>();
            looperHandler.SetupSequence(lh => lh.ContinueLooping()).Returns(true).Returns(false);

            var gameEngine = new GameOfLineEngine(counter.Object, rulesEngine.Object, outputter.Object, looperHandler.Object);
            gameEngine.Process(new bool[1,1]);
        }

        [Fact]
        public void LoopHandlerContinueCalledOnce()
        {
            this.looperHandler.Verify(lh => lh.ContinueLooping(), Times.Exactly(2));
        }

        [Fact]
        public void LoopHandlerPausedCalledOnce()
        {
            this.looperHandler.Verify(lh => lh.Pause(), Times.Once);
        }
    }
}
