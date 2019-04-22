

using IOCDemo.Interface1;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace IOCDemo.Start
{
   public class Ioctest
    {
        public static void show()
        {
            Console.WriteLine("***********************直接实例化**********************");

            {
                //ApplePhone app = new ApplePhone();
                //Console.WriteLine($"app.iHeadphone==null? {app.iHeadphone == null}");
                //Console.WriteLine($"app.iMicrophone == null? {app.iMicrophone == null}");
                //Console.WriteLine($"app.iPower == null? {app.iPower == null}");
            }

            //{

            //    Console.WriteLine("********************unity容器的初步应用***************");
            //    IUnityContainer container = new UnityContainer();//声明一个容器
            //    container.RegisterType<IPhone, AndroidPhone>();//2 初始化容器注册类型 这样才知道具体要有哪个
            //    IPhone phone = container.Resolve<IPhone>();//创建对像 反射创建
            //    phone.Call();
            //}
            {
                //Console.WriteLine("********************unity容器的初步应用***************");
                //IUnityContainer container = new UnityContainer();//声明一个容器
                //container.RegisterType<IPhone, AndroidPhone>();//接口
                //container.RegisterType<AbstractPad, ApplePad>();//抽象类
                //container.RegisterType<ApplePad, ApplePadChild>();//父子类
                //container.RegisterType<AbstractPad, ApplePadChild>();//不起别名就会覆盖 同用一个接口就要起别名
                //container.RegisterType<AbstractPad, ApplePad>("child");//别名 1对多
                //container.RegisterType<AbstractPad, ApplePadChild>("grandchild");// 1对多

                //container.RegisterInstance<ITV>(new AppleTV(1223));//注册实例 不常用 类都实例化了 就是依赖细节

                //IPhone phone = container.Resolve<IPhone>();//创建对像 反射创建
                //phone.Call();
                //AbstractPad ab = new ApplePad();
                //ApplePad ap = new ApplePadChild();
                //var chilidp = container.Resolve<AbstractPad>("child");
                //var cgp = container.Resolve<AbstractPad>("grandchild");
                //chilidp.Show();
                //cgp.Show();

            }

            //{
            //    Console.WriteLine("**********************依赖注入 多层架构******************");
            //    IUnityContainer container = new UnityContainer();
            //    container.RegisterType<IPhone, ApplePhone>();
            //    container.RegisterType<IPower, Power>();
            //    container.RegisterType<IMicrophone, Microphone>();
            //    container.RegisterType<IHeadphone, Headphone>();
            //    IPhone phone = container.Resolve<IPhone>();
            //    phone.Call();
            //}


            //Console.WriteLine("**************Unity生命周期****************");
            //    {

            //    //容器成了对象创建的入口 可以加入自己的管理逻辑 生命周期
            //    IUnityContainer container = new UnityContainer();
            //    container.RegisterType<IPhone, AndroidPhone>(new TransientLifetimeManager());//默认生命周期
            //    var phone1 = container.Resolve<IPhone>();
            //    var phone2 = container.Resolve<IPhone>();
            //    Console.WriteLine(object.ReferenceEquals(phone1, phone2));


            //}

            //不想要类 但是程序运行又必须要细节 配置文件
            Console.WriteLine("********************配置文件读取***************");
           {
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "unityconfig\\Unity.Config");//找配置文件的路径
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

                IUnityContainer container = new UnityContainer();
                section.Configure(container, "testContainer");
                IPhone phone = container.Resolve<IPhone>();
                phone.Call();

                IPhone android = container.Resolve<IPhone>("Android");
                android.Call();

            }
            
        }
    }
}
