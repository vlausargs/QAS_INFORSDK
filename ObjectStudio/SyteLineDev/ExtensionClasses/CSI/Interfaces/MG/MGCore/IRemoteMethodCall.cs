﻿//PROJECT NAME: MG.MGCore
//CLASS NAME: IRemoteMethodCall.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.MG.MGCore
{
    public interface IRemoteMethodCall
    {
        (ICollectionLoadResponse Data, int? ReturnCode, string Infobar) RemoteMethodCallSp(string Site,
        string IdoName,
        string MethodName,
        string StoredProcName = null,
        string Infobar = null,
        string Parm1Value = "",
        string Parm2Value = "",
        string Parm3Value = "",
        string Parm4Value = "",
        string Parm5Value = "",
        string Parm6Value = "",
        string Parm7Value = "",
        string Parm8Value = "",
        string Parm9Value = "",
        string Parm10Value = "",
        string Parm11Value = "",
        string Parm12Value = "",
        string Parm13Value = "",
        string Parm14Value = "",
        string Parm15Value = "",
        string Parm16Value = "",
        string Parm17Value = "",
        string Parm18Value = "",
        string Parm19Value = "",
        string Parm20Value = "",
        string Parm21Value = "",
        string Parm22Value = "",
        string Parm23Value = "",
        string Parm24Value = "",
        string Parm25Value = "",
        string Parm26Value = "",
        string Parm27Value = "",
        string Parm28Value = "",
        string Parm29Value = "",
        string Parm30Value = "",
        string Parm31Value = "",
        string Parm32Value = "",
        string Parm33Value = "",
        string Parm34Value = "",
        string Parm35Value = "",
        string Parm36Value = "",
        string Parm37Value = "",
        string Parm38Value = "",
        string Parm39Value = "",
        string Parm40Value = "",
        string Parm41Value = "",
        string Parm42Value = "",
        string Parm43Value = "",
        string Parm44Value = "",
        string Parm45Value = "",
        string Parm46Value = "",
        string Parm47Value = "",
        string Parm48Value = "",
        string Parm49Value = "",
        string Parm50Value = "",
        string Parm51Value = "",
        string Parm52Value = "",
        string Parm53Value = "",
        string Parm54Value = "",
        string Parm55Value = "",
        string Parm56Value = "",
        string Parm57Value = "",
        string Parm58Value = "",
        string Parm59Value = "",
        string Parm60Value = "",
        string Parm61Value = "",
        string Parm62Value = "",
        string Parm63Value = "",
        string Parm64Value = "",
        string Parm65Value = "",
        string Parm66Value = "",
        string Parm67Value = "",
        string Parm68Value = "",
        string Parm69Value = "",
        string Parm70Value = "",
        string Parm71Value = "",
        string Parm72Value = "",
        string Parm73Value = "",
        string Parm74Value = "",
        string Parm75Value = "",
        string Parm76Value = "",
        string Parm77Value = "",
        string Parm78Value = "",
        string Parm79Value = "",
        string Parm80Value = "",
        string Parm81Value = "",
        string Parm82Value = "",
        string Parm83Value = "",
        string Parm84Value = "",
        string Parm85Value = "",
        string Parm86Value = "",
        string Parm87Value = "",
        string Parm88Value = "",
        string Parm89Value = "",
        string Parm90Value = "",
        string Parm91Value = "",
        string Parm92Value = "",
        string Parm93Value = "",
        string Parm94Value = "",
        string Parm95Value = "",
        string Parm96Value = "",
        string Parm97Value = "",
        string Parm98Value = "",
        string Parm99Value = "",
        string Parm100Value = "",
        string Parm101Value = "",
        string Parm102Value = "",
        string Parm103Value = "",
        string Parm104Value = "",
        string Parm105Value = "",
        string Parm106Value = "",
        string Parm107Value = "",
        string Parm108Value = "",
        string Parm109Value = "",
        string Parm110Value = "",
        string Parm111Value = "",
        string Parm112Value = "",
        string Parm113Value = "",
        string Parm114Value = "",
        string Parm115Value = "",
        string Parm116Value = "",
        string Parm117Value = "",
        string Parm118Value = "",
        string Parm119Value = "",
        string Parm120Value = "",
        string Parm121Value = "",
        string Parm122Value = "",
        string Parm123Value = "",
        string Parm124Value = "",
        string Parm125Value = "",
        string Parm126Value = "",
        string Parm127Value = "",
        string Parm128Value = "",
        string Parm129Value = "",
        string Parm130Value = "",
        string Parm131Value = "",
        string Parm132Value = "",
        string Parm133Value = "",
        string Parm134Value = "",
        string Parm135Value = "",
        string Parm136Value = "",
        string Parm137Value = "",
        string Parm138Value = "",
        string Parm139Value = "",
        string Parm140Value = "",
        string Parm141Value = "",
        string Parm142Value = "",
        string Parm143Value = "",
        string Parm144Value = "",
        string Parm145Value = "",
        string Parm146Value = "",
        string Parm147Value = "",
        string Parm148Value = "",
        string Parm149Value = "",
        string Parm150Value = "",
        string Parm151Value = "",
        string Parm152Value = "",
        string Parm153Value = "",
        string Parm154Value = "",
        string Parm155Value = "",
        string Parm156Value = "",
        string Parm157Value = "",
        string Parm158Value = "",
        string Parm159Value = "",
        string Parm160Value = "",
        string Parm161Value = "",
        string Parm162Value = "",
        string Parm163Value = "",
        string Parm164Value = "",
        string Parm165Value = "",
        string Parm166Value = "",
        string Parm167Value = "",
        string Parm168Value = "",
        string Parm169Value = "",
        string Parm170Value = "",
        string Parm171Value = "",
        string Parm172Value = "",
        string Parm173Value = "",
        string Parm174Value = "",
        string Parm175Value = "",
        string Parm176Value = "",
        string Parm177Value = "",
        string Parm178Value = "",
        string Parm179Value = "",
        string Parm180Value = "",
        string Parm181Value = "",
        string Parm182Value = "",
        string Parm183Value = "",
        string Parm184Value = "",
        string Parm185Value = "",
        string Parm186Value = "",
        string Parm187Value = "",
        string Parm188Value = "",
        string Parm189Value = "",
        string Parm190Value = "",
        string Parm191Value = "",
        string Parm192Value = "",
        string Parm193Value = "",
        string Parm194Value = "",
        string Parm195Value = "",
        string Parm196Value = "",
        string Parm197Value = "",
        string Parm198Value = "",
        string Parm199Value = "",
        string Parm200Value = "",
        Guid RefRowPointer = default(Guid));
    }
}

