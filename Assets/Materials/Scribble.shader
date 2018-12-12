// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:1,cusa:True,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:True,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:1873,x:33928,y:32756,varname:node_1873,prsc:2|emission-5006-OUT,alpha-603-OUT,voffset-810-OUT;n:type:ShaderForge.SFN_Tex2d,id:4805,x:32040,y:32416,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Multiply,id:1086,x:32812,y:32818,cmnt:RGB,varname:node_1086,prsc:2|A-1789-OUT,B-5983-RGB;n:type:ShaderForge.SFN_Color,id:5983,x:32589,y:32818,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_VertexColor,id:5376,x:32831,y:33138,varname:node_5376,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1749,x:33025,y:32818,cmnt:Premultiply Alpha,varname:node_1749,prsc:2|A-1086-OUT,B-603-OUT;n:type:ShaderForge.SFN_Multiply,id:603,x:33106,y:33058,cmnt:A,varname:node_603,prsc:2|A-8588-OUT,B-5983-A,C-5376-A;n:type:ShaderForge.SFN_ValueProperty,id:9642,x:32831,y:33438,ptovrint:False,ptlb:Strength,ptin:_Strength,varname:node_9642,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:5427,x:32522,y:33306,varname:node_5427,prsc:2,ntxv:3,isnm:True|UVIN-7905-UVOUT,TEX-5976-TEX;n:type:ShaderForge.SFN_Append,id:2988,x:32831,y:33296,varname:node_2988,prsc:2|A-5427-R,B-5427-G;n:type:ShaderForge.SFN_Multiply,id:2990,x:33054,y:33201,varname:node_2990,prsc:2|A-2988-OUT,B-9642-OUT;n:type:ShaderForge.SFN_Panner,id:7905,x:32308,y:33269,varname:node_7905,prsc:2,spu:1,spv:0.5|UVIN-9184-UVOUT,DIST-9587-OUT;n:type:ShaderForge.SFN_TexCoord,id:9184,x:32306,y:33753,varname:node_9184,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:9611,x:31536,y:33486,varname:node_9611,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:8137,x:32040,y:32609,ptovrint:False,ptlb:Clothing,ptin:_Clothing,varname:node_8137,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Add,id:4492,x:32251,y:32832,varname:node_4492,prsc:2|A-4805-A,B-8137-A,C-4714-A;n:type:ShaderForge.SFN_Lerp,id:7307,x:32450,y:32226,varname:node_7307,prsc:2|A-8485-OUT,B-8137-RGB,T-8137-A;n:type:ShaderForge.SFN_Color,id:2075,x:32040,y:32234,ptovrint:False,ptlb:SkinColor,ptin:_SkinColor,varname:node_2075,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Blend,id:8485,x:32247,y:32226,varname:node_8485,prsc:2,blmd:0,clmp:True|SRC-2075-RGB,DST-4805-RGB;n:type:ShaderForge.SFN_Floor,id:8524,x:32087,y:33486,varname:node_8524,prsc:2|IN-4265-OUT;n:type:ShaderForge.SFN_Multiply,id:4265,x:31910,y:33486,varname:node_4265,prsc:2|A-2544-OUT,B-6055-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6055,x:31729,y:33649,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_6055,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:3299,x:32087,y:33636,ptovrint:False,ptlb:Amplitude,ptin:_Amplitude,varname:node_3299,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:9587,x:32306,y:33417,varname:node_9587,prsc:2|A-8524-OUT,B-3299-OUT;n:type:ShaderForge.SFN_Color,id:1193,x:33025,y:32570,ptovrint:False,ptlb:Glow,ptin:_Glow,varname:node_1193,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Add,id:9004,x:33303,y:32714,varname:node_9004,prsc:2|A-8612-OUT,B-1749-OUT;n:type:ShaderForge.SFN_Multiply,id:8612,x:33251,y:32506,varname:node_8612,prsc:2|A-1193-RGB,B-4805-A;n:type:ShaderForge.SFN_Step,id:8720,x:32442,y:32966,cmnt:I dont know why this works,varname:node_8720,prsc:2|A-266-OUT,B-4492-OUT;n:type:ShaderForge.SFN_Vector1,id:266,x:32251,y:32966,varname:node_266,prsc:2,v1:0.95;n:type:ShaderForge.SFN_Tex2d,id:4714,x:32040,y:32793,ptovrint:False,ptlb:Armor,ptin:_Armor,varname:node_4714,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Lerp,id:1789,x:32703,y:32226,varname:node_1789,prsc:2|A-7307-OUT,B-4714-RGB,T-4714-A;n:type:ShaderForge.SFN_Add,id:7637,x:32657,y:32981,varname:node_7637,prsc:2|A-8720-OUT,B-4805-A;n:type:ShaderForge.SFN_Clamp01,id:8588,x:32831,y:33011,varname:node_8588,prsc:2|IN-7637-OUT;n:type:ShaderForge.SFN_Add,id:2544,x:31729,y:33486,varname:node_2544,prsc:2|A-3396-OUT,B-9611-T;n:type:ShaderForge.SFN_ValueProperty,id:3396,x:31536,y:33426,ptovrint:False,ptlb:TimeOffset,ptin:_TimeOffset,varname:node_3396,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Blend,id:6352,x:33525,y:33311,varname:node_6352,prsc:2,blmd:7,clmp:True|SRC-9004-OUT,DST-9544-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4215,x:33303,y:32902,ptovrint:False,ptlb:Elite,ptin:_Elite,varname:node_4215,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Tex2d,id:9673,x:32909,y:33653,varname:node_9673,prsc:2,ntxv:3,isnm:True|UVIN-8060-UVOUT,TEX-5447-TEX;n:type:ShaderForge.SFN_Panner,id:8060,x:32715,y:33673,varname:node_8060,prsc:2,spu:-0.05,spv:-0.07|UVIN-9184-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:3647,x:32965,y:33897,varname:node_3647,prsc:2,ntxv:3,isnm:True|UVIN-4410-UVOUT,TEX-5447-TEX;n:type:ShaderForge.SFN_Panner,id:4410,x:32711,y:33859,varname:node_4410,prsc:2,spu:0.05,spv:-0.03|UVIN-9184-UVOUT;n:type:ShaderForge.SFN_Blend,id:9544,x:33348,y:33703,varname:node_9544,prsc:2,blmd:6,clmp:True|SRC-9673-RGB,DST-3647-RGB;n:type:ShaderForge.SFN_Add,id:810,x:33279,y:33231,varname:node_810,prsc:2|A-2990-OUT,B-7909-OUT;n:type:ShaderForge.SFN_Multiply,id:7909,x:33176,y:33475,varname:node_7909,prsc:2|A-9544-OUT,B-4843-OUT,C-4215-OUT;n:type:ShaderForge.SFN_Vector1,id:4843,x:32831,y:33515,varname:node_4843,prsc:2,v1:0.04;n:type:ShaderForge.SFN_Tex2dAsset,id:5976,x:32306,y:33585,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_5976,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2dAsset,id:5447,x:32573,y:34084,ptovrint:False,ptlb:EliteNormal,ptin:_EliteNormal,varname:node_5447,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Multiply,id:5713,x:33536,y:32997,varname:node_5713,prsc:2|A-4215-OUT,B-6911-OUT,C-6352-OUT;n:type:ShaderForge.SFN_Vector1,id:6911,x:33303,y:32973,varname:node_6911,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Add,id:5006,x:33713,y:32785,varname:node_5006,prsc:2|A-9004-OUT,B-5713-OUT;proporder:4805-8137-4714-5983-9642-2075-6055-3299-1193-3396-4215-5976-5447;pass:END;sub:END;*/

Shader "Shader Forge/Scribble" {
    Properties {
        _MainTex ("MainTex", 2D) = "black" {}
        _Clothing ("Clothing", 2D) = "black" {}
        _Armor ("Armor", 2D) = "black" {}
        _Color ("Color", Color) = (1,1,1,1)
        _Strength ("Strength", Float ) = 1
        _SkinColor ("SkinColor", Color) = (1,1,1,1)
        _Speed ("Speed", Float ) = 1
        _Amplitude ("Amplitude", Float ) = 1
        _Glow ("Glow", Color) = (0,0,0,1)
        _TimeOffset ("TimeOffset", Float ) = 0
        _Elite ("Elite", Float ) = 0
        _Normal ("Normal", 2D) = "bump" {}
        _EliteNormal ("EliteNormal", 2D) = "bump" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
        [MaterialToggle] PixelSnap ("Pixel snap", Float) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
            "CanUseSpriteAtlas"="True"
            "PreviewType"="Plane"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #pragma multi_compile _ PIXELSNAP_ON
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _Color;
            uniform float _Strength;
            uniform sampler2D _Clothing; uniform float4 _Clothing_ST;
            uniform float4 _SkinColor;
            uniform float _Speed;
            uniform float _Amplitude;
            uniform float4 _Glow;
            uniform sampler2D _Armor; uniform float4 _Armor_ST;
            uniform float _TimeOffset;
            uniform float _Elite;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform sampler2D _EliteNormal; uniform float4 _EliteNormal_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                float4 node_9611 = _Time;
                float2 node_7905 = (o.uv0+(floor(((_TimeOffset+node_9611.g)*_Speed))*_Amplitude)*float2(1,0.5));
                float3 node_5427 = UnpackNormal(tex2Dlod(_Normal,float4(TRANSFORM_TEX(node_7905, _Normal),0.0,0)));
                float4 node_2320 = _Time;
                float2 node_8060 = (o.uv0+node_2320.g*float2(-0.05,-0.07));
                float3 node_9673 = UnpackNormal(tex2Dlod(_EliteNormal,float4(TRANSFORM_TEX(node_8060, _EliteNormal),0.0,0)));
                float2 node_4410 = (o.uv0+node_2320.g*float2(0.05,-0.03));
                float3 node_3647 = UnpackNormal(tex2Dlod(_EliteNormal,float4(TRANSFORM_TEX(node_4410, _EliteNormal),0.0,0)));
                float3 node_9544 = saturate((1.0-(1.0-node_9673.rgb)*(1.0-node_3647.rgb)));
                v.vertex.xyz += (float3((float2(node_5427.r,node_5427.g)*_Strength),0.0)+(node_9544*0.04*_Elite));
                o.pos = UnityObjectToClipPos( v.vertex );
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float4 _Clothing_var = tex2D(_Clothing,TRANSFORM_TEX(i.uv0, _Clothing));
                float4 _Armor_var = tex2D(_Armor,TRANSFORM_TEX(i.uv0, _Armor));
                float node_603 = (saturate((step(0.95,(_MainTex_var.a+_Clothing_var.a+_Armor_var.a))+_MainTex_var.a))*_Color.a*i.vertexColor.a); // A
                float3 node_9004 = ((_Glow.rgb*_MainTex_var.a)+((lerp(lerp(saturate(min(_SkinColor.rgb,_MainTex_var.rgb)),_Clothing_var.rgb,_Clothing_var.a),_Armor_var.rgb,_Armor_var.a)*_Color.rgb)*node_603));
                float4 node_2320 = _Time;
                float2 node_8060 = (i.uv0+node_2320.g*float2(-0.05,-0.07));
                float3 node_9673 = UnpackNormal(tex2D(_EliteNormal,TRANSFORM_TEX(node_8060, _EliteNormal)));
                float2 node_4410 = (i.uv0+node_2320.g*float2(0.05,-0.03));
                float3 node_3647 = UnpackNormal(tex2D(_EliteNormal,TRANSFORM_TEX(node_4410, _EliteNormal)));
                float3 node_9544 = saturate((1.0-(1.0-node_9673.rgb)*(1.0-node_3647.rgb)));
                float3 emissive = (node_9004+(_Elite*0.5*saturate((node_9544/(1.0-node_9004)))));
                float3 finalColor = emissive;
                return fixed4(finalColor,node_603);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #pragma multi_compile _ PIXELSNAP_ON
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform float _Strength;
            uniform float _Speed;
            uniform float _Amplitude;
            uniform float _TimeOffset;
            uniform float _Elite;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform sampler2D _EliteNormal; uniform float4 _EliteNormal_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 node_9611 = _Time;
                float2 node_7905 = (o.uv0+(floor(((_TimeOffset+node_9611.g)*_Speed))*_Amplitude)*float2(1,0.5));
                float3 node_5427 = UnpackNormal(tex2Dlod(_Normal,float4(TRANSFORM_TEX(node_7905, _Normal),0.0,0)));
                float4 node_1557 = _Time;
                float2 node_8060 = (o.uv0+node_1557.g*float2(-0.05,-0.07));
                float3 node_9673 = UnpackNormal(tex2Dlod(_EliteNormal,float4(TRANSFORM_TEX(node_8060, _EliteNormal),0.0,0)));
                float2 node_4410 = (o.uv0+node_1557.g*float2(0.05,-0.03));
                float3 node_3647 = UnpackNormal(tex2Dlod(_EliteNormal,float4(TRANSFORM_TEX(node_4410, _EliteNormal),0.0,0)));
                float3 node_9544 = saturate((1.0-(1.0-node_9673.rgb)*(1.0-node_3647.rgb)));
                v.vertex.xyz += (float3((float2(node_5427.r,node_5427.g)*_Strength),0.0)+(node_9544*0.04*_Elite));
                o.pos = UnityObjectToClipPos( v.vertex );
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
