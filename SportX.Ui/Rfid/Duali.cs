using System.Runtime.InteropServices;

namespace SportX.Ui.Rfid;
public class Duali
{
    [DllImport("DualCardDll.dll")]
    public static extern int DE_InitPort(int nPort, int nBaud);

    [DllImport("DualCardDll.dll")]
    public static extern int DE_BuzzerOn(int nPort);

    [DllImport("DualCardDll.dll")]
    public static extern int DE_BuzzerOff(int nPort);

    [DllImport("DualCardDll.dll")]
    public static extern void DE_ClosePort(int nPort);

    [DllImport("DualCardDll.dll")]
    public static extern void DE_GetVersion(int nPort, out int outlen, byte[] lpRes);

    [DllImport("DualCardDll.dll")]
    public static extern int DEA_Idle_Req(int nPort, out int outlen, byte[] lpRes);

    [DllImport("DualCardDll.dll")]
    public static extern int DEA_Anticoll(int nPort, byte level, out int outlen, byte[] lpRes);

    [DllImport("DualCardDll.dll")]
    public static extern int DEA_Select(int nPort, byte[] uid, out int outlen, byte[] lpRes);

    [DllImport("DualCardDll.dll")]
    public static extern int DEA_Authkey(int nPort, byte mode, byte[] keydata, byte blockno);

    [DllImport("DualCardDll.dll")]
    public static extern int DEA_Read(int nPort, byte blockno, out int outlen, byte[] lpRes);

    [DllImport("DualCardDll.dll")]
    public static extern int DEA_Write(int nPort, byte blockno, int datalen, byte[] data);

    [DllImport("DualCardDll.dll")]
    public static extern int GetErrMsg(int errcode, char[] retmsg);

    [DllImport("DualCardDll.dll")]
    public static extern int DE_RFOn(int nPort);

    [DllImport("DualCardDll.dll")]
    public static extern int DE_RFOff(int nPort);

    [DllImport("DualCardDll.dll")]
    public static extern int DEB_Transparent(int nPort, byte datalen, byte[] data, byte TOUT, out byte outlen, byte[] lpRes);

    [DllImport("DualCardDll.dll")]
    public static extern int DEA_Loadkey(int nPort, byte mode, byte keyno, byte[] keydata);

    [DllImport("DualCardDll.dll")]
    public static extern int DEA_Req_AuthRead(int nPort, byte requestmode, byte authmode, byte keyno, byte blockno, out int outlen, byte[] lpRes);
}
