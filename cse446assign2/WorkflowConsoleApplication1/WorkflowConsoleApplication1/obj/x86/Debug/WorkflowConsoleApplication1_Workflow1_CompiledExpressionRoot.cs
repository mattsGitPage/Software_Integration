namespace WorkflowConsoleApplication1 {
    
    #line 30 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 31 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 32 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 33 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 34 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 35 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using WorkflowConsoleApplication1.ServiceReference2.Activities;
    
    #line default
    #line hidden
    
    #line 36 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using WorkflowConsoleApplication1.ServiceReference2;
    
    #line default
    #line hidden
    
    #line 37 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using WcfService2;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\WorkflowConsoleApplication1\WorkflowConsoleApplication1\Workflow1.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Workflow1 : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Workflow1_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext0 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext2(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2 refDataContext1 = ((Workflow1_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext2 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext3 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext2(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2 refDataContext4 = ((Workflow1_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext5 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext2(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2 refDataContext6 = ((Workflow1_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext7 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext8 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3 refDataContext9 = ((Workflow1_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext9.GetLocation<int>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext10 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext11 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3 refDataContext12 = ((Workflow1_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext13 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext14 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext15 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext15.GetLocation<int>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext16 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext17 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext18 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext18.GetLocation<int>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext19 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext20 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3 refDataContext21 = ((Workflow1_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext21.GetLocation<string>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext22 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext23 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext24 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext25 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext26 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext27 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext28 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext28.GetLocation<string>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext29 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6_ForReadOnly valDataContext30 = ((Workflow1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6_ForReadOnly valDataContext31 = ((Workflow1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow1_TypedDataContext6(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6 refDataContext32 = ((Workflow1_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6_ForReadOnly valDataContext33 = ((Workflow1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6_ForReadOnly valDataContext34 = ((Workflow1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow1_TypedDataContext6(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6 refDataContext35 = ((Workflow1_TypedDataContext6)(cachedCompiledDataContext[9]));
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext36 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext37 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[7]));
                return refDataContext37.GetLocation<string>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext38 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3 refDataContext39 = ((Workflow1_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext39.GetLocation<string>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext40 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext2(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2 refDataContext41 = ((Workflow1_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext41.GetLocation<string>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext0 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Workflow1_TypedDataContext2 refDataContext1 = new Workflow1_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext2 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext3 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Workflow1_TypedDataContext2 refDataContext4 = new Workflow1_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext5 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                Workflow1_TypedDataContext2 refDataContext6 = new Workflow1_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext7 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext8 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                Workflow1_TypedDataContext3 refDataContext9 = new Workflow1_TypedDataContext3(locations, true);
                return refDataContext9.GetLocation<int>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext10 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext11 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                Workflow1_TypedDataContext3 refDataContext12 = new Workflow1_TypedDataContext3(locations, true);
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext13 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext14 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Workflow1_TypedDataContext4 refDataContext15 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext15.GetLocation<int>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext16 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext17 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                Workflow1_TypedDataContext4 refDataContext18 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext18.GetLocation<int>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext19 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext20 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Workflow1_TypedDataContext3 refDataContext21 = new Workflow1_TypedDataContext3(locations, true);
                return refDataContext21.GetLocation<string>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext22 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext23 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                Workflow1_TypedDataContext5 refDataContext24 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext25 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                Workflow1_TypedDataContext5 refDataContext26 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext27 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                Workflow1_TypedDataContext5 refDataContext28 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext28.GetLocation<string>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext29 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                Workflow1_TypedDataContext6_ForReadOnly valDataContext30 = new Workflow1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                Workflow1_TypedDataContext6_ForReadOnly valDataContext31 = new Workflow1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                Workflow1_TypedDataContext6 refDataContext32 = new Workflow1_TypedDataContext6(locations, true);
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                Workflow1_TypedDataContext6_ForReadOnly valDataContext33 = new Workflow1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                Workflow1_TypedDataContext6_ForReadOnly valDataContext34 = new Workflow1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                Workflow1_TypedDataContext6 refDataContext35 = new Workflow1_TypedDataContext6(locations, true);
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext36 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                Workflow1_TypedDataContext5 refDataContext37 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext37.GetLocation<string>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext38 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                Workflow1_TypedDataContext3 refDataContext39 = new Workflow1_TypedDataContext3(locations, true);
                return refDataContext39.GetLocation<string>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext40 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                Workflow1_TypedDataContext2 refDataContext41 = new Workflow1_TypedDataContext2(locations, true);
                return refDataContext41.GetLocation<string>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "userName") 
                        && (Workflow1_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"thank you \" + userName + \" please enter your password\"") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "password") 
                        && (Workflow1_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "password") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "result") 
                        && (Workflow1_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "userName") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "result == true") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "account") 
                        && (Workflow1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"your account balance is currently : $\" + account") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "add") 
                        && (Workflow1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "add == \"y\"") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Convert.ToInt32(Console.ReadLine())") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "amountAdded") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "amountAdded") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "account") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "newAccount") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"successfully added your account is now $\" + newAccount") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "encrypt") 
                        && (Workflow1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "encrypt == \"y\"") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "stringE") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "stringE") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "resultE") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "view") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "view == \"y\"") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"your encrypted message is \" + resultE") 
                        && (Workflow1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "resultE") 
                        && (Workflow1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "decryptR") 
                        && (Workflow1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"your decrypted message is \" + decryptR") 
                        && (Workflow1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "terminate") 
                        && (Workflow1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "terminate") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "terminate") 
                        && (Workflow1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "terminate") 
                        && (Workflow1_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Workflow1_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Workflow1_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Workflow1_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Workflow1_TypedDataContext3(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Workflow1_TypedDataContext3(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Workflow1_TypedDataContext3(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Workflow1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Workflow1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Workflow1_TypedDataContext6(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Workflow1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Workflow1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new Workflow1_TypedDataContext6(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Workflow1_TypedDataContext3(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Workflow1_TypedDataContext2(locationReferences).@__Expr41GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1 : Workflow1_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int newAccount;
            
            protected bool result;
            
            protected int account;
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.newAccount = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.result = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.account = ((int)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.newAccount);
                this.SetVariableValue((1 + locationsOffset), this.result);
                this.SetVariableValue((2 + locationsOffset), this.account);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "newAccount") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "result") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "account") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow1_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1_ForReadOnly : Workflow1_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int newAccount;
            
            protected bool result;
            
            protected int account;
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.newAccount = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.result = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.account = ((int)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "newAccount") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "result") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "account") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow1_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext2 : Workflow1_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string userName {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string password {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected string terminate {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected string encrypt {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected string stringE {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected string view {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected WorkflowConsoleApplication1.ServiceReference2.addToAccountRequest data {
                get {
                    return ((WorkflowConsoleApplication1.ServiceReference2.addToAccountRequest)(this.GetVariableValue((9 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((9 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 78 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                userName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr1Get() {
                
                #line 78 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                userName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(string value) {
                
                #line 78 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                userName = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 95 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                password;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 95 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                password;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(string value) {
                
                #line 95 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                password = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 110 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  result;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 110 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                  result;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(bool value) {
                
                #line 110 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                  result = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 368 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            terminate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr41Get() {
                
                #line 368 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                            terminate;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(string value) {
                
                #line 368 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                            terminate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 3)].Name != "userName") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "password") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "terminate") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "encrypt") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "stringE") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "view") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "data") 
                            || (locationReferences[(offset + 9)].Type != typeof(WorkflowConsoleApplication1.ServiceReference2.addToAccountRequest)))) {
                    return false;
                }
                return Workflow1_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext2_ForReadOnly : Workflow1_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string userName {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string password {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected string terminate {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected string encrypt {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected string stringE {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected string view {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected WorkflowConsoleApplication1.ServiceReference2.addToAccountRequest data {
                get {
                    return ((WorkflowConsoleApplication1.ServiceReference2.addToAccountRequest)(this.GetVariableValue((9 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 83 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 83 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 89 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              "thank you " + userName + " please enter your password";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 89 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
              "thank you " + userName + " please enter your password";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 100 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 100 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 115 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  password;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr5Get() {
                
                #line 115 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                  password;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 120 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  userName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 120 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                  userName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 129 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      result == true;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 129 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                      result == true;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 373 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr40Get() {
                
                #line 373 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                            Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 3)].Name != "userName") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "password") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "terminate") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "encrypt") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "stringE") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "view") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "data") 
                            || (locationReferences[(offset + 9)].Type != typeof(WorkflowConsoleApplication1.ServiceReference2.addToAccountRequest)))) {
                    return false;
                }
                return Workflow1_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext3 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string add {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 141 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            account;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr9Get() {
                
                #line 141 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                            account;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(int value) {
                
                #line 141 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                            account = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 154 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            add;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 154 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                            add;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(string value) {
                
                #line 154 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                            add = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 216 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            encrypt;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 216 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                            encrypt;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(string value) {
                
                #line 216 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                            encrypt = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 348 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  terminate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 348 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  terminate;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(string value) {
                
                #line 348 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                                  terminate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 10)].Name != "add") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext3_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string add {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 147 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          "your account balance is currently : $" + account;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 147 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                          "your account balance is currently : $" + account;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 159 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr11Get() {
                
                #line 159 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                            Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 166 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            add == "y";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 166 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                            add == "y";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 221 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 221 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                            Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 228 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            encrypt == "y";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 228 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                            encrypt == "y";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 353 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr38Get() {
                
                #line 353 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 10)].Name != "add") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext4 : Workflow1_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int amountAdded;
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 178 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  amountAdded;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr15Get() {
                
                #line 178 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  amountAdded;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(int value) {
                
                #line 178 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                                  amountAdded = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 190 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  newAccount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr18Get() {
                
                #line 190 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  newAccount;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(int value) {
                
                #line 190 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                                  newAccount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.amountAdded = ((int)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.amountAdded);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "amountAdded") 
                            || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow1_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext4_ForReadOnly : Workflow1_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int amountAdded;
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 183 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  Convert.ToInt32(Console.ReadLine());
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr14Get() {
                
                #line 183 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  Convert.ToInt32(Console.ReadLine());
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 195 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  amountAdded;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr16Get() {
                
                #line 195 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  amountAdded;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 200 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  account;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr17Get() {
                
                #line 200 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  account;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 206 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                "successfully added your account is now $" + newAccount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 206 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                "successfully added your account is now $" + newAccount;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            protected override void GetValueTypeValues() {
                this.amountAdded = ((int)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "amountAdded") 
                            || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow1_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext5 : Workflow1_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string resultE {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 240 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  stringE;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 240 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  stringE;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(string value) {
                
                #line 240 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                                  stringE = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 252 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  resultE;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 252 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  resultE;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(string value) {
                
                #line 252 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                                  resultE = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 265 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  view;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr28Get() {
                
                #line 265 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  view;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(string value) {
                
                #line 265 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                                  view = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 328 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        terminate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 328 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                        terminate;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(string value) {
                
                #line 328 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                                        terminate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "resultE") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext5_ForReadOnly : Workflow1_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string resultE {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 245 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 245 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 257 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  stringE;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 257 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  stringE;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 270 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr27Get() {
                
                #line 270 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 277 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  view == "y";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr29Get() {
                
                #line 277 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                  view == "y";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 333 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 333 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                        Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "resultE") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext6 : Workflow1_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string decryptR {
                get {
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((12 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 293 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        decryptR;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 293 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                        decryptR;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(string value) {
                
                #line 293 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                                        decryptR = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 311 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        terminate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 311 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                        terminate;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(string value) {
                
                #line 311 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                
                                        terminate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 12)].Name != "decryptR") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext6_ForReadOnly : Workflow1_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string decryptR {
                get {
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 287 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "your encrypted message is " + resultE;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 287 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                      "your encrypted message is " + resultE;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 298 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        resultE;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr31Get() {
                
                #line 298 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                        resultE;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 304 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "your decrypted message is " + decryptR;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 304 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                      "your decrypted message is " + decryptR;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 316 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr34Get() {
                
                #line 316 "C:\USERS\MATTHEW DUNNING\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\WORKFLOWCONSOLEAPPLICATION1\WORKFLOWCONSOLEAPPLICATION1\WORKFLOW1.XAML"
                return 
                                        Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 12)].Name != "decryptR") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
