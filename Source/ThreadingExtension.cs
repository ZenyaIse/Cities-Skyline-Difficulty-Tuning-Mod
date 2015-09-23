using System;
using ICities;

namespace DifficultyTuningMod
{
    public class ThreadingExtension : IThreadingExtension
    {
        public void OnAfterSimulationFrame()
        {
            //ExtendedInfoPanelsObject.Update();
        }

        public void OnAfterSimulationTick()
        {
            // Empty
        }

        public void OnBeforeSimulationFrame()
        {
            // Empty
        }

        public void OnBeforeSimulationTick()
        {
            // Empty
        }

        public void OnCreated(IThreading threading)
        {
            // Empty
        }

        public void OnReleased()
        {
            // Empty
        }

        public void OnUpdate(float realTimeDelta, float simulationTimeDelta)
        {
            // Empty
        }
    }
}
