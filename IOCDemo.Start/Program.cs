
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemo.Start
{
   public class Program
    {
        /// <summary>
        /// 1 IOC控制反转和DI依赖注入介绍
        /// 2 Unity容器使用/生命周期管理/配置文件/特殊类型
        /// 3 Unity的AOP应用
        /// 
        /// 分层架构是必须的
        /// DIP依赖倒置原则：系统架构时，高层模块不应该依赖于低层模块，二者通过抽象来依赖
        ///               依赖抽象，而不是细节
        ///               
        /// 贯彻依赖倒置原则，左边能抽象，右边实例化的时候不能直接用抽象，所以需要借助一个第三方
        /// 
        /// 高层本来是依赖低层，但是可以通过工厂(容器)来决定细节，去掉了对低层的依赖
        /// IOC控制反转：把高层对低层的依赖，转移到第三方决定，避免高层对低层的直接依赖(是一种目的)
        ///              那么程序架构就具备良好扩展性和稳定性
        ///              
        ///  DI依赖注入：是用来实现IOC的一种手段,
        ///              在构造对象时，可以自动的去初始化，对象需要的对象
        ///              构造函数注入  属性注入   方法注入
        ///              不管是构造对象，还是注入对象，这里都是靠反射做到的
        ///  有了依赖注入，才可能做到无限层级的依赖抽象，才能做到控制反转
        ///  
      
        /// </summary>
        public static void Main(string[] args)
        {
            //IPhone p = ObjectFactory.CreatePhone();


            Ioctest.show();
        }
    }
}
