//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NFDefine.proto
namespace NFMsg
{
    [global::ProtoBuf.ProtoContract(Name=@"EGameEventCode")]
    public enum EGameEventCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_SUCCESS", Value=0)]
      EGEC_SUCCESS = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_UNKOWN_ERROR", Value=1)]
      EGEC_UNKOWN_ERROR = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACCOUNT_EXIST", Value=2)]
      EGEC_ACCOUNT_EXIST = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACCOUNTPWD_INVALID", Value=3)]
      EGEC_ACCOUNTPWD_INVALID = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACCOUNT_USING", Value=4)]
      EGEC_ACCOUNT_USING = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACCOUNT_LOCKED", Value=5)]
      EGEC_ACCOUNT_LOCKED = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACCOUNT_SUCCESS", Value=6)]
      EGEC_ACCOUNT_SUCCESS = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_VERIFY_KEY_SUCCESS", Value=7)]
      EGEC_VERIFY_KEY_SUCCESS = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_VERIFY_KEY_FAIL", Value=8)]
      EGEC_VERIFY_KEY_FAIL = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_SELECTSERVER_SUCCESS", Value=9)]
      EGEC_SELECTSERVER_SUCCESS = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_SELECTSERVER_FAIL", Value=10)]
      EGEC_SELECTSERVER_FAIL = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_CHARACTER_EXIST", Value=110)]
      EGEC_CHARACTER_EXIST = 110,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_SVRZONEID_INVALID", Value=111)]
      EGEC_SVRZONEID_INVALID = 111,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_CHARACTER_NUMOUT", Value=112)]
      EGEC_CHARACTER_NUMOUT = 112,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_CHARACTER_INVALID", Value=113)]
      EGEC_CHARACTER_INVALID = 113,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_CHARACTER_NOTEXIST", Value=114)]
      EGEC_CHARACTER_NOTEXIST = 114,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_CHARACTER_USING", Value=115)]
      EGEC_CHARACTER_USING = 115,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_CHARACTER_LOCKED", Value=116)]
      EGEC_CHARACTER_LOCKED = 116,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ZONE_OVERLOAD", Value=117)]
      EGEC_ZONE_OVERLOAD = 117,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_NOT_ONLINE", Value=118)]
      EGEC_NOT_ONLINE = 118,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ALREAY_IN_TEAM", Value=119)]
      EGEC_ALREAY_IN_TEAM = 119,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_INVALID_TEAM_INVITE", Value=120)]
      EGEC_INVALID_TEAM_INVITE = 120,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_TEAM_FULL", Value=121)]
      EGEC_TEAM_FULL = 121,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_MAIL_UPDATE_ERROR", Value=122)]
      EGEC_MAIL_UPDATE_ERROR = 122,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_MAIL_TONAME_INVALID", Value=123)]
      EGEC_MAIL_TONAME_INVALID = 123,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_MAIL_DELETE_ERROR", Value=124)]
      EGEC_MAIL_DELETE_ERROR = 124,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_MAIL_TOWNAME_EQUAL", Value=125)]
      EGEC_MAIL_TOWNAME_EQUAL = 125,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_LACK_MONEY", Value=126)]
      EGEC_LACK_MONEY = 126,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_FULL_PACKAGE", Value=127)]
      EGEC_FULL_PACKAGE = 127,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_INVALID_ITEM", Value=128)]
      EGEC_INVALID_ITEM = 128,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_INVALID_CONSIGNMENT", Value=129)]
      EGEC_INVALID_CONSIGNMENT = 129,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_NOT_ENOUGH_VIP", Value=130)]
      EGEC_NOT_ENOUGH_VIP = 130,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_NEED_LEVEL", Value=131)]
      EGEC_NEED_LEVEL = 131,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_MAX_FRIEND_LIST", Value=132)]
      EGEC_MAX_FRIEND_LIST = 132,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_MAX_ENEMY_LIST", Value=133)]
      EGEC_MAX_ENEMY_LIST = 133,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_MAX_GANGS_LSIT", Value=134)]
      EGEC_MAX_GANGS_LSIT = 134,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_LIMITS_TO_RIGHTS", Value=135)]
      EGEC_LIMITS_TO_RIGHTS = 135,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_INVALID_GANGS_NAME", Value=136)]
      EGEC_INVALID_GANGS_NAME = 136,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REPEAT_ENTER_GANGS", Value=137)]
      EGEC_REPEAT_ENTER_GANGS = 137,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_INVALID_GANGSMEMBER", Value=138)]
      EGEC_INVALID_GANGSMEMBER = 138,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_MASTER_LEAVE_GANGS", Value=139)]
      EGEC_MASTER_LEAVE_GANGS = 139,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_GANGS_TITLE_OUTOF", Value=140)]
      EGEC_GANGS_TITLE_OUTOF = 140,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ENTER_GATEWAY_FAILD", Value=141)]
      EGEC_ENTER_GATEWAY_FAILD = 141,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_NO_SERVER4ZONE", Value=142)]
      EGEC_NO_SERVER4ZONE = 142,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_INVALID_SKILL", Value=143)]
      EGEC_INVALID_SKILL = 143,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ENTER_GAME_SUCCESS", Value=144)]
      EGEC_ENTER_GAME_SUCCESS = 144,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_CREATE_GUILD_SUCCESS", Value=200)]
      EGEC_CREATE_GUILD_SUCCESS = 200,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_JOIN_GUILD_SUCCESS", Value=201)]
      EGEC_JOIN_GUILD_SUCCESS = 201,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_LEAVE_GUILD_SUCCESS", Value=202)]
      EGEC_LEAVE_GUILD_SUCCESS = 202
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGameMsgID")]
    public enum EGameMsgID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_UNKNOW", Value=0)]
      EGMI_UNKNOW = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_EVENT_RESULT", Value=1)]
      EGMI_EVENT_RESULT = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_EVENT_TRANSPOND", Value=2)]
      EGMI_EVENT_TRANSPOND = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_CLOSE_SOCKET", Value=3)]
      EGMI_CLOSE_SOCKET = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_MTL_WORLD_REGISTERED", Value=10)]
      EGMI_MTL_WORLD_REGISTERED = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_MTL_WORLD_UNREGISTERED", Value=11)]
      EGMI_MTL_WORLD_UNREGISTERED = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_MTL_WORLD_REFRESH", Value=12)]
      EGMI_MTL_WORLD_REFRESH = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_LTM_LOGIN_REGISTERED", Value=20)]
      EGMI_LTM_LOGIN_REGISTERED = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_LTM_LOGIN_UNREGISTERED", Value=21)]
      EGMI_LTM_LOGIN_UNREGISTERED = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_LTM_LOGIN_REFRESH", Value=22)]
      EGMI_LTM_LOGIN_REFRESH = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_PTWG_PROXY_REGISTERED", Value=30)]
      EGMI_PTWG_PROXY_REGISTERED = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_PTWG_PROXY_UNREGISTERED", Value=31)]
      EGMI_PTWG_PROXY_UNREGISTERED = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_PTWG_PROXY_REFRESH", Value=32)]
      EGMI_PTWG_PROXY_REFRESH = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_GTW_GAME_REGISTERED", Value=40)]
      EGMI_GTW_GAME_REGISTERED = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_GTW_GAME_UNREGISTERED", Value=41)]
      EGMI_GTW_GAME_UNREGISTERED = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_GTW_GAME_REFRESH", Value=42)]
      EGMI_GTW_GAME_REFRESH = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_STS_NET_INFO", Value=50)]
      EGMI_STS_NET_INFO = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_STS_HEART_BEAT", Value=100)]
      EGMI_STS_HEART_BEAT = 100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_LOGIN", Value=101)]
      EGMI_REQ_LOGIN = 101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_LOGIN", Value=102)]
      EGMI_ACK_LOGIN = 102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_LOGOUT", Value=103)]
      EGMI_REQ_LOGOUT = 103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_WORLD_LIST", Value=110)]
      EGMI_REQ_WORLD_LIST = 110,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_WORLD_LIST", Value=111)]
      EGMI_ACK_WORLD_LIST = 111,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CONNECT_WORLD", Value=112)]
      EGMI_REQ_CONNECT_WORLD = 112,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CONNECT_WORLD", Value=113)]
      EGMI_ACK_CONNECT_WORLD = 113,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_KICK_CLIENT_INWORLD", Value=114)]
      EGMI_REQ_KICK_CLIENT_INWORLD = 114,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CONNECT_KEY", Value=120)]
      EGMI_REQ_CONNECT_KEY = 120,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CONNECT_KEY", Value=122)]
      EGMI_ACK_CONNECT_KEY = 122,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_SELECT_SERVER", Value=130)]
      EGMI_REQ_SELECT_SERVER = 130,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_SELECT_SERVER", Value=131)]
      EGMI_ACK_SELECT_SERVER = 131,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_ROLE_LIST", Value=132)]
      EGMI_REQ_ROLE_LIST = 132,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_ROLE_LIST", Value=133)]
      EGMI_ACK_ROLE_LIST = 133,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CREATE_ROLE", Value=134)]
      EGMI_REQ_CREATE_ROLE = 134,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_DELETE_ROLE", Value=135)]
      EGMI_REQ_DELETE_ROLE = 135,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_RECOVER_ROLE", Value=136)]
      EGMI_REQ_RECOVER_ROLE = 136,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_ENTER_GAME", Value=150)]
      EGMI_REQ_ENTER_GAME = 150,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_ENTER_GAME", Value=151)]
      EGMI_ACK_ENTER_GAME = 151,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_LEAVE_GAME", Value=152)]
      EGMI_REQ_LEAVE_GAME = 152,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_LEAVE_GAME", Value=153)]
      EGMI_ACK_LEAVE_GAME = 153,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_SWAP_GAME", Value=154)]
      EGMI_REQ_SWAP_GAME = 154,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_SWAP_SCENE", Value=155)]
      EGMI_REQ_SWAP_SCENE = 155,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_SWAP_SCENE", Value=156)]
      EGMI_ACK_SWAP_SCENE = 156,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_END_BATTLE", Value=157)]
      EGMI_REQ_END_BATTLE = 157,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_END_BATTLE", Value=158)]
      EGMI_ACK_END_BATTLE = 158,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_OBJECT_ENTRY", Value=200)]
      EGMI_ACK_OBJECT_ENTRY = 200,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_OBJECT_LEAVE", Value=201)]
      EGMI_ACK_OBJECT_LEAVE = 201,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_OBJECT_PROPERTY_ENTRY", Value=202)]
      EGMI_ACK_OBJECT_PROPERTY_ENTRY = 202,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_OBJECT_RECORD_ENTRY", Value=203)]
      EGMI_ACK_OBJECT_RECORD_ENTRY = 203,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_PROPERTY_INT", Value=210)]
      EGMI_ACK_PROPERTY_INT = 210,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_PROPERTY_FLOAT", Value=211)]
      EGMI_ACK_PROPERTY_FLOAT = 211,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_PROPERTY_STRING", Value=212)]
      EGMI_ACK_PROPERTY_STRING = 212,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_PROPERTY_DOUBLE", Value=213)]
      EGMI_ACK_PROPERTY_DOUBLE = 213,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_PROPERTY_OBJECT", Value=214)]
      EGMI_ACK_PROPERTY_OBJECT = 214,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_ADD_ROW", Value=220)]
      EGMI_ACK_ADD_ROW = 220,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_REMOVE_ROW", Value=221)]
      EGMI_ACK_REMOVE_ROW = 221,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_SWAP_ROW", Value=222)]
      EGMI_ACK_SWAP_ROW = 222,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_RECORD_INT", Value=223)]
      EGMI_ACK_RECORD_INT = 223,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_RECORD_FLOAT", Value=224)]
      EGMI_ACK_RECORD_FLOAT = 224,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_RECORD_DOUBLE", Value=225)]
      EGMI_ACK_RECORD_DOUBLE = 225,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_RECORD_STRING", Value=226)]
      EGMI_ACK_RECORD_STRING = 226,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_RECORD_OBJECT", Value=227)]
      EGMI_ACK_RECORD_OBJECT = 227,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_RECORD_CLEAR", Value=228)]
      EGMI_ACK_RECORD_CLEAR = 228,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_RECORD_SORT", Value=229)]
      EGMI_ACK_RECORD_SORT = 229,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_MOVE", Value=230)]
      EGMI_REQ_MOVE = 230,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_MOVE", Value=231)]
      EGMI_ACK_MOVE = 231,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_MOVE_IMMUNE", Value=232)]
      EGMI_REQ_MOVE_IMMUNE = 232,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_MOVE_IMMUNE", Value=233)]
      EGMI_ACK_MOVE_IMMUNE = 233,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_SKILL_OBJECTX", Value=240)]
      EGMI_REQ_SKILL_OBJECTX = 240,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_SKILL_OBJECTX", Value=241)]
      EGMI_ACK_SKILL_OBJECTX = 241,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_SKILL_POS", Value=242)]
      EGMI_REQ_SKILL_POS = 242,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_SKILL_POS", Value=243)]
      EGMI_ACK_SKILL_POS = 243,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_ITEM_OBJECT", Value=244)]
      EGMI_REQ_ITEM_OBJECT = 244,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_ITEM_OBJECT", Value=245)]
      EGMI_ACK_ITEM_OBJECT = 245,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_ITEM_POS", Value=246)]
      EGMI_REQ_ITEM_POS = 246,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_ITEM_POS", Value=247)]
      EGMI_ACK_ITEM_POS = 247,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CHAT", Value=250)]
      EGMI_REQ_CHAT = 250,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CHAT", Value=251)]
      EGMI_ACK_CHAT = 251,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_SALE_ITEM", Value=252)]
      EGMI_REQ_SALE_ITEM = 252,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_SPLIT_ITEM", Value=253)]
      EGMI_REQ_SPLIT_ITEM = 253,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_PRODUCE_ITEM", Value=254)]
      EGMI_REQ_PRODUCE_ITEM = 254,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_PICK_ITEM", Value=255)]
      EGMI_REQ_PICK_ITEM = 255,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_ACCEPT_TASK", Value=256)]
      EGMI_REQ_ACCEPT_TASK = 256,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_COMPELETE_TASK", Value=257)]
      EGMI_REQ_COMPELETE_TASK = 257,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_JOIN_PVP", Value=260)]
      EGMI_REQ_JOIN_PVP = 260,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_EXIT_PVP", Value=261)]
      EGMI_REQ_EXIT_PVP = 261,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMT_ACK_START_PVP", Value=262)]
      EGMT_ACK_START_PVP = 262,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_SEARCH_OPPNENT", Value=280)]
      EGMI_REQ_SEARCH_OPPNENT = 280,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_SEARCH_OPPNENT", Value=281)]
      EGMI_ACK_SEARCH_OPPNENT = 281,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMT_REQ_START_OPPNENT", Value=282)]
      EGMT_REQ_START_OPPNENT = 282,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMT_ACK_START_OPPNENT", Value=283)]
      EGMT_ACK_START_OPPNENT = 283,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_ONLINE_NOTIFY", Value=290)]
      EGMI_ACK_ONLINE_NOTIFY = 290,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_OFFLINE_NOTIFY", Value=291)]
      EGMI_ACK_OFFLINE_NOTIFY = 291,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CREATE_GUILD", Value=300)]
      EGMI_REQ_CREATE_GUILD = 300,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CREATE_GUILD", Value=301)]
      EGMI_ACK_CREATE_GUILD = 301,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_JOIN_GUILD", Value=302)]
      EGMI_REQ_JOIN_GUILD = 302,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_JOIN_GUILD", Value=303)]
      EGMI_ACK_JOIN_GUILD = 303,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_LEAVE_GUILD", Value=304)]
      EGMI_REQ_LEAVE_GUILD = 304,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_LEAVE_GUILD", Value=305)]
      EGMI_ACK_LEAVE_GUILD = 305,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_OPR_GUILD", Value=306)]
      EGMI_REQ_OPR_GUILD = 306,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_OPR_GUILD", Value=307)]
      EGMI_ACK_OPR_GUILD = 307,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_SEARCH_GUILD", Value=308)]
      EGMI_REQ_SEARCH_GUILD = 308,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_SEARCH_GUILD", Value=309)]
      EGMI_ACK_SEARCH_GUILD = 309,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_OPR_GUILDINFO", Value=310)]
      EGMI_REQ_OPR_GUILDINFO = 310,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_OPR_GUILDINFO", Value=311)]
      EGMI_ACK_OPR_GUILDINFO = 311,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_GUILDECTYPEINFO", Value=312)]
      EGMI_REQ_GUILDECTYPEINFO = 312,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_GUILDECTYPEINFO", Value=313)]
      EGMI_ACK_GUILDECTYPEINFO = 313,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_SET_GUILDECTYPEINFO", Value=314)]
      EGMI_SET_GUILDECTYPEINFO = 314,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ReqEnterGuildEctype", Value=315)]
      EGMI_ReqEnterGuildEctype = 315,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_CREATE_CHATGROUP", Value=400)]
      EGEC_REQ_CREATE_CHATGROUP = 400,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_CREATE_CHATGROUP", Value=401)]
      EGEC_ACK_CREATE_CHATGROUP = 401,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_JOIN_CHATGROUP", Value=402)]
      EGEC_REQ_JOIN_CHATGROUP = 402,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_JOIN_CHATGROUP", Value=403)]
      EGEC_ACK_JOIN_CHATGROUP = 403,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_LEAVE_CHATGROUP", Value=404)]
      EGEC_REQ_LEAVE_CHATGROUP = 404,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_LEAVE_CHATGROUP", Value=405)]
      EGEC_ACK_LEAVE_CHATGROUP = 405,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_SUBSCRIPTION_CHATGROUP", Value=406)]
      EGEC_REQ_SUBSCRIPTION_CHATGROUP = 406,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_CANCELSUBSCRIPTION_CHATGROUP", Value=407)]
      EGEC_REQ_CANCELSUBSCRIPTION_CHATGROUP = 407,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_INVITE_CHATGROUP", Value=408)]
      EGEC_REQ_INVITE_CHATGROUP = 408,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_INVITE_CHATGROUP", Value=409)]
      EGEC_ACK_INVITE_CHATGROUP = 409,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_KICK_CHATGROUP", Value=410)]
      EGEC_REQ_KICK_CHATGROUP = 410,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_KICK_CHATGROUP", Value=411)]
      EGEC_ACK_KICK_CHATGROUP = 411,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_CHATGROUP_TO_TEAM", Value=450)]
      EGEC_REQ_CHATGROUP_TO_TEAM = 450,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_CHATGROUP_TO_TEAM", Value=451)]
      EGEC_ACK_CHATGROUP_TO_TEAM = 451,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_INTENSIFYLEVEL_TO_EQUIP", Value=500)]
      EGEC_REQ_INTENSIFYLEVEL_TO_EQUIP = 500,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_INTENSIFYLEVEL_TO_EQUIP", Value=501)]
      EGEC_ACK_INTENSIFYLEVEL_TO_EQUIP = 501,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_HOLE_TO_EQUIP", Value=502)]
      EGEC_REQ_HOLE_TO_EQUIP = 502,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_HOLE_TO_EQUIP", Value=503)]
      EGEC_ACK_HOLE_TO_EQUIP = 503,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_INLAYSTONE_TO_EQUIP", Value=504)]
      EGEC_REQ_INLAYSTONE_TO_EQUIP = 504,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_INLAYSTONE_TO_EQUIP", Value=505)]
      EGEC_ACK_INLAYSTONE_TO_EQUIP = 505,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_ELEMENTLEVEL_TO_EQUIP", Value=506)]
      EGEC_REQ_ELEMENTLEVEL_TO_EQUIP = 506,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_ACK_ELEMENTLEVEL_TO_EQUIP", Value=507)]
      EGEC_ACK_ELEMENTLEVEL_TO_EQUIP = 507,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_SET_FIGHT_HERO", Value=508)]
      EGEC_REQ_SET_FIGHT_HERO = 508,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_WEAR_EQUIP", Value=509)]
      EGEC_WEAR_EQUIP = 509,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_TAKEOFF_EQUIP", Value=510)]
      EGEC_TAKEOFF_EQUIP = 510,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_MINING_TITLE", Value=600)]
      EGEC_REQ_MINING_TITLE = 600,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_SEND_MAIL", Value=700)]
      EGEC_REQ_SEND_MAIL = 700,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_DRAW_MAIL", Value=701)]
      EGEC_REQ_DRAW_MAIL = 701,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGEC_REQ_DELETE_MAIL", Value=702)]
      EGEC_REQ_DELETE_MAIL = 702,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_OBJECT_ENTRY", Value=800)]
      EGMI_ACK_CLONE_OBJECT_ENTRY = 800,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_OBJECT_LEAVE", Value=801)]
      EGMI_ACK_CLONE_OBJECT_LEAVE = 801,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_OBJECT_PROPERTY_ENTRY", Value=802)]
      EGMI_ACK_CLONE_OBJECT_PROPERTY_ENTRY = 802,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_OBJECT_RECORD_ENTRY", Value=803)]
      EGMI_ACK_CLONE_OBJECT_RECORD_ENTRY = 803,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_PROPERTY_INT", Value=810)]
      EGMI_ACK_CLONE_PROPERTY_INT = 810,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_PROPERTY_FLOAT", Value=811)]
      EGMI_ACK_CLONE_PROPERTY_FLOAT = 811,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_PROPERTY_STRING", Value=812)]
      EGMI_ACK_CLONE_PROPERTY_STRING = 812,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_PROPERTY_DOUBLE", Value=813)]
      EGMI_ACK_CLONE_PROPERTY_DOUBLE = 813,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_PROPERTY_OBJECT", Value=814)]
      EGMI_ACK_CLONE_PROPERTY_OBJECT = 814,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_ADD_ROW", Value=820)]
      EGMI_ACK_CLONE_ADD_ROW = 820,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_REMOVE_ROW", Value=821)]
      EGMI_ACK_CLONE_REMOVE_ROW = 821,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_SWAP_ROW", Value=822)]
      EGMI_ACK_CLONE_SWAP_ROW = 822,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_RECORD_INT", Value=823)]
      EGMI_ACK_CLONE_RECORD_INT = 823,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_RECORD_FLOAT", Value=824)]
      EGMI_ACK_CLONE_RECORD_FLOAT = 824,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_RECORD_DOUBLE", Value=825)]
      EGMI_ACK_CLONE_RECORD_DOUBLE = 825,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_RECORD_STRING", Value=826)]
      EGMI_ACK_CLONE_RECORD_STRING = 826,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_RECORD_OBJECT", Value=827)]
      EGMI_ACK_CLONE_RECORD_OBJECT = 827,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_RECORD_CLEAR", Value=828)]
      EGMI_ACK_CLONE_RECORD_CLEAR = 828,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_CLONE_RECORD_SORT", Value=829)]
      EGMI_ACK_CLONE_RECORD_SORT = 829,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CMD_PROPERTY_INT", Value=1000)]
      EGMI_REQ_CMD_PROPERTY_INT = 1000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CMD_PROPERTY_STR", Value=1001)]
      EGMI_REQ_CMD_PROPERTY_STR = 1001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CMD_PROPERTY_OBJECT", Value=1002)]
      EGMI_REQ_CMD_PROPERTY_OBJECT = 1002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CMD_PROPERTY_FLOAT", Value=1003)]
      EGMI_REQ_CMD_PROPERTY_FLOAT = 1003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CMD_RECORD_INT", Value=1004)]
      EGMI_REQ_CMD_RECORD_INT = 1004,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CMD_RECORD_STR", Value=1005)]
      EGMI_REQ_CMD_RECORD_STR = 1005,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CMD_RECORD_OBJECT", Value=1006)]
      EGMI_REQ_CMD_RECORD_OBJECT = 1006,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CMD_RECORD_FLOAT", Value=1007)]
      EGMI_REQ_CMD_RECORD_FLOAT = 1007,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CMD_NORMAL", Value=1008)]
      EGMI_REQ_CMD_NORMAL = 1008,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_BUY_FORM_SHOP", Value=10000)]
      EGMI_REQ_BUY_FORM_SHOP = 10000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_BUY_FORM_SHOP", Value=10001)]
      EGMI_ACK_BUY_FORM_SHOP = 10001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_MOVE_BUILD_OBJECT", Value=10002)]
      EGMI_REQ_MOVE_BUILD_OBJECT = 10002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_ACK_MOVE_BUILD_OBJECT", Value=10003)]
      EGMI_ACK_MOVE_BUILD_OBJECT = 10003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_UP_BUILD_LVL", Value=10101)]
      EGMI_REQ_UP_BUILD_LVL = 10101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_CREATE_ITEM", Value=10102)]
      EGMI_REQ_CREATE_ITEM = 10102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGMI_REQ_BUILD_OPERATE", Value=10103)]
      EGMI_REQ_BUILD_OPERATE = 10103
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EItemType")]
    public enum EItemType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_NORMAL", Value=0)]
      EIT_NORMAL = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_EQUIP", Value=1)]
      EIT_EQUIP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_BOUNTY", Value=2)]
      EIT_BOUNTY = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_HERO_CARD", Value=3)]
      EIT_HERO_CARD = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_HERO_STONE", Value=4)]
      EIT_HERO_STONE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_STRENGTHEN_STONE", Value=5)]
      EIT_STRENGTHEN_STONE = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_DEMONIZATION_STONE", Value=6)]
      EIT_DEMONIZATION_STONE = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_GEM_STONE", Value=7)]
      EIT_GEM_STONE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_CURRENCY", Value=8)]
      EIT_CURRENCY = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_ITEM_REBORN", Value=9)]
      EIT_ITEM_REBORN = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_ITEM_POSITION", Value=10)]
      EIT_ITEM_POSITION = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_WOOD", Value=100)]
      EIT_WOOD = 100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EIT_STONE", Value=101)]
      EIT_STONE = 101
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGameEquipSubType")]
    public enum EGameEquipSubType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_WEAPON", Value=0)]
      EQUIPTYPE_WEAPON = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_ARMOR", Value=1)]
      EQUIPTYPE_ARMOR = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_NECKLACE", Value=2)]
      EQUIPTYPE_NECKLACE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_RING", Value=3)]
      EQUIPTYPE_RING = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_EARRINGS", Value=4)]
      EQUIPTYPE_EARRINGS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_BADGE", Value=5)]
      EQUIPTYPE_BADGE = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_HELMET", Value=6)]
      EQUIPTYPE_HELMET = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_SHAWL", Value=7)]
      EQUIPTYPE_SHAWL = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_GLOVE", Value=8)]
      EQUIPTYPE_GLOVE = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_WRIST", Value=9)]
      EQUIPTYPE_WRIST = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_BELT", Value=10)]
      EQUIPTYPE_BELT = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_PANT", Value=11)]
      EQUIPTYPE_PANT = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_BOOT", Value=12)]
      EQUIPTYPE_BOOT = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_WING", Value=13)]
      EQUIPTYPE_WING = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_CLOAK", Value=14)]
      EQUIPTYPE_CLOAK = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIPTYPE_FASHION", Value=15)]
      EQUIPTYPE_FASHION = 15
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGameElementType")]
    public enum EGameElementType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EELEMENTTYPE_WIND", Value=0)]
      EELEMENTTYPE_WIND = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EELEMENTTYPE_FIRE", Value=1)]
      EELEMENTTYPE_FIRE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EELEMENTTYPE_THUNDER", Value=2)]
      EELEMENTTYPE_THUNDER = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EELEMENTTYPE_SOIL", Value=3)]
      EELEMENTTYPE_SOIL = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EELEMENTTYPE_WATER", Value=4)]
      EELEMENTTYPE_WATER = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGameItemSubType")]
    public enum EGameItemSubType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIT_ITEM_NONE", Value=0)]
      EGIT_ITEM_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIT_ITEM_PROPERTY_CARD", Value=1)]
      EGIT_ITEM_PROPERTY_CARD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIT_ITEM_PVP_ATTACK_CARD", Value=2)]
      EGIT_ITEM_PVP_ATTACK_CARD = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIT_ITEM_PVP_DEFENSE_CARD", Value=3)]
      EGIT_ITEM_PVP_DEFENSE_CARD = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIT_ITEM_SKILL_CARD", Value=4)]
      EGIT_ITEM_SKILL_CARD = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIT_ITEM_GUILD_SKILL_CARD", Value=5)]
      EGIT_ITEM_GUILD_SKILL_CARD = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIT_ITEM_GUILD_DIAMOND", Value=6)]
      EGIT_ITEM_GUILD_DIAMOND = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIT_ITEM_WORLD_HORN", Value=7)]
      EGIT_ITEM_WORLD_HORN = 7
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGameItemExpiredType")]
    public enum EGameItemExpiredType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIET_NONE", Value=0)]
      EGIET_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIET_USE_TIMES", Value=1)]
      EGIET_USE_TIMES = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIET_REAL_TIME", Value=2)]
      EGIET_REAL_TIME = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGIET_END_INDEX", Value=3)]
      EGIET_END_INDEX = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EDrawDropItemState")]
    public enum EDrawDropItemState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"E_DRAW_STATE_NONE", Value=0)]
      E_DRAW_STATE_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"E_DRAW_STATE_GAIN", Value=1)]
      E_DRAW_STATE_GAIN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"E_DRAW_STATE_RECV", Value=2)]
      E_DRAW_STATE_RECV = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGuildPowerType")]
    public enum EGuildPowerType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"GUILD_POWER_TYPE_NORMAL", Value=0)]
      GUILD_POWER_TYPE_NORMAL = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GUILD_POWER_TYPE_VICE_PRESIDENT", Value=1)]
      GUILD_POWER_TYPE_VICE_PRESIDENT = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GUILD_POWER_TYPE_PRESIDENT", Value=2)]
      GUILD_POWER_TYPE_PRESIDENT = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ETaskState")]
    public enum ETaskState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_IN_PROCESS", Value=0)]
      TASK_IN_PROCESS = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_DONE", Value=1)]
      TASK_DONE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_DRAW_AWARD", Value=2)]
      TASK_DRAW_AWARD = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_FINISH", Value=3)]
      TASK_FINISH = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ETaskType")]
    public enum ETaskType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_LEVEL_UPDATE_SOME_LEVEL", Value=0)]
      TASK_LEVEL_UPDATE_SOME_LEVEL = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_PASS_ECTYPE", Value=1)]
      TASK_PASS_ECTYPE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_PASS_ECTYPE_COUNT", Value=2)]
      TASK_PASS_ECTYPE_COUNT = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_PASS_SOME_TYPE_ECTYPE_COUNT", Value=3)]
      TASK_PASS_SOME_TYPE_ECTYPE_COUNT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_UPDATE_SKILL_COUNT", Value=4)]
      TASK_UPDATE_SKILL_COUNT = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_CONSUME_MONEY", Value=5)]
      TASK_CONSUME_MONEY = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_CONSUME_DIAMOND", Value=6)]
      TASK_CONSUME_DIAMOND = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_ARENA_COUNT", Value=7)]
      TASK_ARENA_COUNT = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_KILL_MONSTER_COUNT", Value=8)]
      TASK_KILL_MONSTER_COUNT = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK_KILL_SOME_MONSTER_COUNT", Value=9)]
      TASK_KILL_SOME_MONSTER_COUNT = 9
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EBattleType")]
    public enum EBattleType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_SINGLE", Value=0)]
      BATTLE_SINGLE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_PVE_TEAM", Value=1)]
      BATTLE_PVE_TEAM = 1
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EShopType")]
    public enum EShopType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EST_BUILDING", Value=1)]
      EST_BUILDING = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EST_GOLD", Value=2)]
      EST_GOLD = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EST_DIAMOND", Value=3)]
      EST_DIAMOND = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EST_SP", Value=4)]
      EST_SP = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EST_EQUIP", Value=5)]
      EST_EQUIP = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EST_GEM", Value=6)]
      EST_GEM = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EST_Hero", Value=7)]
      EST_Hero = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EST_Other", Value=8)]
      EST_Other = 8
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EFightPos")]
    public enum EFightPos
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFP_MINER1", Value=0)]
      EFP_MINER1 = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFP_HERO1", Value=1)]
      EFP_HERO1 = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFP_MINER2", Value=2)]
      EFP_MINER2 = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFP_HERO2", Value=3)]
      EFP_HERO2 = 3
    }
  
}