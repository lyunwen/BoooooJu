using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineDemo
{
    /// <summary>
    /// 成长
    /// </summary>
    public class IGrowIng
    {
        public delegate void GrowDg(IGrowContext context);
        public delegate void BornDg(IGrowContext context);
        public delegate void BabyStepDg(IGrowContext context);
        public delegate void InfantSetpDg(IGrowContext context);
        public delegate void PupilStepDg(IGrowContext context);
        public delegate void MiddelStudentStepDg(IGrowContext context);
        public delegate void CollegeStudenSteptDg(IGrowContext context);
        public delegate void WorkingStepDg(IGrowContext context);
        public IGrowIng(IPeopleFactory factory)
        {
            _currentPeople = factory.CreatePeople(new BornContext());
        }

        private IPeople _currentPeople;

        public IPeople CurrentPeople
        {
            get
            { return _currentPeople; }
            private set
            { _currentPeople = value; }
        }

        /// <summary>
        /// 出生
        /// </summary>
        public event BornDg Born;

        /// <summary>
        /// 婴儿期事件
        /// </summary>
        public event BabyStepDg BabyStep;

        /// <summary>
        /// 幼儿期事件
        /// </summary>
        public event InfantSetpDg InfantSetp;

        /// <summary>
        /// 小学生阶段
        /// </summary>
        public event PupilStepDg PupilStep;

        /// <summary>
        /// 中学生
        /// </summary>
        public event MiddelStudentStepDg MiddelStudentStep;

        /// <summary>
        /// 大学生阶段
        /// </summary>
        public event CollegeStudenSteptDg CollegeStudenStept;

        /// <summary>
        /// 工作阶段
        /// </summary>
        public event WorkingStepDg WorkingStep;

        /// <summary>
        /// 死亡
        /// </summary>
        public event GrowDg Die;
    }
}
