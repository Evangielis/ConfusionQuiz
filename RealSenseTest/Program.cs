using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealSenseTest
{
    class Program
    {
        static void Main(string[] args)
        {
// Create the SenseManager instance
PXCMSenseManager sm=PXCMSenseManager.CreateInstance();
 
// Enable face trackcing
sm.EnableFace();
 
// Get a face instance here (or inside the AcquireFrame/ReleaseFrame loop) for configuration
PXCMFaceModule face=sm.QueryFace();
//...
 
// Initialize the pipeline
sm.Init();
 
// Stream data
while (sm.AcquireFrame(true)>=pxcmStatus.PXCM_STATUS_NO_ERROR) {
  // retrieve the face tracking results
  PXCMFaceModule face2=sm.QueryFace();
  if (sm!=null) {
  //   ...
      Console.WriteLine("Do stuff!");
  }
 
  // Resume next frame processing
  sm.ReleaseFrame();
}
 
// Clean up
sm.Dispose();
        }
    }
}
