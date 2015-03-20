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
            PXCMSession ss = PXCMSession.CreateInstance();
            PXCMSenseManager sm = ss.CreateSenseManager();
 
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
              if (sm!=null) {
                  PXCMFaceConfiguration conf = face.CreateActiveConfiguration();
                  conf.EnableAllAlerts();
                  conf.ApplyChanges();
                  PXCMFaceData data = face.CreateOutput();
                  PXCMFaceData.AlertData adata;
                  try
                  {
                      Console.WriteLine(data.QueryNumberOfDetectedFaces());
                      data.IsAlertFired(PXCMFaceData.AlertData.AlertType.ALERT_NEW_FACE_DETECTED, out adata);
                      Console.WriteLine(adata.faceId);
                  }
                  finally
                  {
                      conf.Dispose();
                      data.Dispose();
                  }

              }
 
              // Resume next frame processing
              sm.ReleaseFrame();
            }
 
            // Clean up
            sm.Dispose();
        }
    }
}
