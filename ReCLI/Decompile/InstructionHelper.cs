using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCLI.Decompile
{
    public class InstructionHelper
    {
        public static int GetCodeIndex(Code code)
        {
            switch (code)
            {
                case Code.Ldarg_S:
                case Code.Ldarg:
                case Code.Stloc_S:
                case Code.Stloc:
                case Code.Ldc_I4:
                case Code.Ldloc:
                case Code.Ldloc_S:
                    return -1;
                case Code.Ldloc_0:
                case Code.Ldarg_0:
                case Code.Stloc_0:
                case Code.Ldc_I4_0:
                    return 0;
                case Code.Ldloc_1:
                case Code.Ldarg_1:
                case Code.Stloc_1:
                case Code.Ldc_I4_1:
                    return 1;
                case Code.Ldloc_2:
                case Code.Ldarg_2:
                case Code.Stloc_2:
                case Code.Ldc_I4_2:
                    return 2;
                case Code.Ldloc_3:
                case Code.Ldarg_3:
                case Code.Stloc_3:
                case Code.Ldc_I4_3:
                    return 3;
                case Code.Ldc_I4_4:
                    return 4;
                case Code.Ldc_I4_5:
                    return 5;
                case Code.Ldc_I4_6:
                    return 6;
                case Code.Ldc_I4_7:
                    return 7;
                case Code.Ldc_I4_8:
                    return 8;
            }
            return -1;
        }

        public static bool IsBranchConditionalEQ(Code code)
        {
            return code == Code.Beq || code == Code.Beq_S;
        }

        public static bool IsBranchConditionalLT(Code code)
        {
            return code == Code.Blt || code == Code.Blt_S || code == Code.Blt_Un || code == Code.Blt_Un_S;
        }

        public static bool IsBranchConditionalLE(Code code)
        {
            return code == Code.Ble || code == Code.Ble_S || code == Code.Ble_Un || code == Code.Ble_Un_S;
        }

        public static bool IsBranchConditionalGT(Code code)
        {
            return code == Code.Bgt || code == Code.Bgt_S || code == Code.Bgt_Un || code == Code.Bgt_Un_S;
        }

        public static bool IsBranchConditionalGE(Code code)
        {
            return code == Code.Bge || code == Code.Bge_S || code == Code.Bge_Un || code == Code.Bge_Un_S;
        }

        public static bool IsBranchOnFalse(Code code)
        {
            return code == Code.Brfalse || code == Code.Brfalse_S;
        }

        public static bool IsBranchOnTrue(Code code)
        {
            return code == Code.Brtrue || code == Code.Brtrue_S;
        }

        public static bool IsBranchConditional(Code code)
        {
            return code == Code.Beq || code == Code.Beq_S || code == Code.Bgt || code == Code.Bgt_S || code == Code.Bgt_Un
                    || code == Code.Bgt_Un_S || code == Code.Blt || code == Code.Blt_Un || code == Code.Blt_S || code == Code.Blt_Un_S
                    || code == Code.Ble || code == Code.Ble_Un || code == Code.Ble_S || code == Code.Ble_Un_S || code == Code.Bge
                    || code == Code.Bge_Un || code == Code.Bge_S || code == Code.Bge_Un_S || code == Code.Brfalse|| code == Code.Brfalse_S || code == Code.Brtrue || code == Code.Brtrue_S;
        }

        public static bool IsConverToNumber(Code code)
        {
            return code == Code.Conv_I || code == Code.Conv_I1 || code == Code.Conv_I2 || code == Code.Conv_I4
                    || code == Code.Conv_I8 || code == Code.Conv_Ovf_I || code == Code.Conv_Ovf_I_Un || code == Code.Conv_Ovf_I1
                    || code == Code.Conv_Ovf_I1_Un || code == Code.Conv_Ovf_I2 || code == Code.Conv_Ovf_I2_Un
                    || code == Code.Conv_Ovf_I4 || code == Code.Conv_Ovf_I4_Un || code == Code.Conv_Ovf_I8
                    || code == Code.Conv_Ovf_I8_Un || code == Code.Conv_R_Un || code == Code.Conv_R4 || code == Code.Conv_R8;
        }

        public static bool IsLoadN(Code code)
        {
            return code == Code.Ldarg_S || code == Code.Ldarg || code == Code.Ldc_I4_S || code == Code.Ldc_I4 ||
                   code == Code.Ldc_R8 || code == Code.Ldc_R4 || code == Code.Ldc_I8 || code == Code.Ldc_I4_S || code == Code.Ldloc_S;
        }

        public static bool IsLoadArgs(Code code)
        {
            return code == Code.Ldarg || code == Code.Ldarg_0 || code == Code.Ldarg_1 || code == Code.Ldarg_2
                    || code == Code.Ldarg_3 || code == Code.Ldarg_S;
        }

        public static bool IsCallMethod(Code code)
        {
            return code == Code.Call || code == Code.Calli || code == Code.Callvirt;
        }


        public static bool IsLoadString(Code code)
        {
            return code == Code.Ldstr;
        }


        public static bool IsLoadInteger(Code code)
        {
            return code == Code.Ldc_I4 || code == Code.Ldc_I4_0 || code == Code.Ldc_I4_1 || code == Code.Ldc_I4_2
                    || code == Code.Ldc_I4_3 || code == Code.Ldc_I4_4 || code == Code.Ldc_I4_5 || code == Code.Ldc_I4_6
                    || code == Code.Ldc_I4_7 || code == Code.Ldc_I4_8 || code == Code.Ldc_I4_S || code == Code.Ldc_I8
                    || code == Code.Ldc_R4 || code == Code.Ldc_R8;
        }

        public static bool IsLoadField(Code code)
        {
            return code == Code.Ldfld || code == Code.Ldflda;
        }

        public static bool IsLoadLocalVariable(Code code)
        {
            return code == Code.Ldloc_0 || code == Code.Ldloc || code == Code.Ldloc_1 || code == Code.Ldloc_2
                    || code == Code.Ldloc_3 || code == Code.Ldloc_S;
        }

        public static bool IsLoad(Code code)
        {
            return IsLoadArgs(code) || IsLoadInteger(code) || IsLoadLocalVariable(code) || IsLoadString(code);
        }

        public static bool IsStore(Code code)
        {
            return IsStoreField(code) || IsStoreElement(code) || IsStoreLocalVariable(code) || IsStoreArgument(code);
        }


        public static bool IsStoreN(Code code)
        {
            return code == Code.Stloc_S || code == Code.Stloc || code == Code.Stfld || code == Code.Starg || code == Code.Starg_S;
        }


        public static bool IsStoreArgument(Code code)
        {
            return code == Code.Starg || code == Code.Starg_S;
        }

        public static bool IsStoreField(Code code)
        {
            return code == Code.Stfld;
        }

        public static bool IsStoreLocalVariable(Code code)
        {
            return code == Code.Stloc || code == Code.Stloc_0 || code == Code.Stloc_1 || code == Code.Stloc_2
                    || code == Code.Stloc_3 || code == Code.Stloc_S;
        }

        public static bool IsConditional(Code code)
        {
            return IsGreaterThan(code) || IsLessThan(code) || IsEqualTo(code);
        }

        public static bool IsGreaterThan(Code code)
        {
            return code == Code.Cgt || code == Code.Cgt_Un;
        }

        public static bool IsLessThan(Code code)
        {
            return code == Code.Clt || code == Code.Clt_Un;
        }

        public static bool IsEqualTo(Code code)
        {
            return code == Code.Ceq;
        }

        public static bool IsMath(Code code)
        {
            return code == Code.Add || code == Code.Sub || code == Code.Div || code == Code.Mul;
        }


        public static bool IsLoadElement(Code code)
        {
            return code == Code.Ldelem_Any || code == Code.Ldelem_I || code == Code.Ldelem_I1 || code == Code.Ldelem_I2
                    || code == Code.Ldelem_I4 || code == Code.Ldelem_I8 || code == Code.Ldelem_R4 || code == Code.Ldelem_R8
                    || code == Code.Ldelem_Ref || code == Code.Ldelem_U1 || code == Code.Ldelem_U2 || code == Code.Ldelem_U4
                    || code == Code.Ldelema;
        }

        public static bool IsStoreElement(Code code)
        {
            return code == Code.Stelem_Any || code == Code.Stelem_I || code == Code.Stelem_I1 || code == Code.Stelem_I2
                    || code == Code.Stelem_I4 || code == Code.Stelem_I8 || code == Code.Stelem_R4 || code == Code.Stelem_R8
                    || code == Code.Stelem_Ref;
        }

        public static bool IsNewInstance(Code code)
        {
            return IsNewArrayInstance(code) || IsNewObjectInstance(code);
        }

        public static bool IsNewArrayInstance(Code code)
        {
            return code == Code.Newarr;
        }

        public static bool IsNewObjectInstance(Code code)
        {
            return code == Code.Newobj;
        }

        public static bool IsLoadNull(Code code)
        {
            return code == Code.Ldnull;
        }
    }
}
