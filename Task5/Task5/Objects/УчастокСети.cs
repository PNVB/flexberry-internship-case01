﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Task5
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// УчастокСети.
    /// </summary>
    // *** Start programmer edit section *** (УчастокСети CustomAttributes)

    // *** End programmer edit section *** (УчастокСети CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class УчастокСети : ICSSoft.STORMNET.DataObject
    {
        
        private string fТипИзоляции;
        
        private string fТипПрокладки;
        
        private int fГодПрокладки;
        
        private IIS.Task5.ОбъектТеплопотребления fОбъектТеплопотребления;
        
        // *** Start programmer edit section *** (УчастокСети CustomMembers)

        // *** End programmer edit section *** (УчастокСети CustomMembers)

        
        /// <summary>
        /// ТипИзоляции.
        /// </summary>
        // *** Start programmer edit section *** (УчастокСети.ТипИзоляции CustomAttributes)

        // *** End programmer edit section *** (УчастокСети.ТипИзоляции CustomAttributes)
        [StrLen(255)]
        public virtual string ТипИзоляции
        {
            get
            {
                // *** Start programmer edit section *** (УчастокСети.ТипИзоляции Get start)

                // *** End programmer edit section *** (УчастокСети.ТипИзоляции Get start)
                string result = this.fТипИзоляции;
                // *** Start programmer edit section *** (УчастокСети.ТипИзоляции Get end)

                // *** End programmer edit section *** (УчастокСети.ТипИзоляции Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (УчастокСети.ТипИзоляции Set start)

                // *** End programmer edit section *** (УчастокСети.ТипИзоляции Set start)
                this.fТипИзоляции = value;
                // *** Start programmer edit section *** (УчастокСети.ТипИзоляции Set end)

                // *** End programmer edit section *** (УчастокСети.ТипИзоляции Set end)
            }
        }
        
        /// <summary>
        /// ТипПрокладки.
        /// </summary>
        // *** Start programmer edit section *** (УчастокСети.ТипПрокладки CustomAttributes)

        // *** End programmer edit section *** (УчастокСети.ТипПрокладки CustomAttributes)
        [StrLen(255)]
        public virtual string ТипПрокладки
        {
            get
            {
                // *** Start programmer edit section *** (УчастокСети.ТипПрокладки Get start)

                // *** End programmer edit section *** (УчастокСети.ТипПрокладки Get start)
                string result = this.fТипПрокладки;
                // *** Start programmer edit section *** (УчастокСети.ТипПрокладки Get end)

                // *** End programmer edit section *** (УчастокСети.ТипПрокладки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (УчастокСети.ТипПрокладки Set start)

                // *** End programmer edit section *** (УчастокСети.ТипПрокладки Set start)
                this.fТипПрокладки = value;
                // *** Start programmer edit section *** (УчастокСети.ТипПрокладки Set end)

                // *** End programmer edit section *** (УчастокСети.ТипПрокладки Set end)
            }
        }
        
        /// <summary>
        /// ГодПрокладки.
        /// </summary>
        // *** Start programmer edit section *** (УчастокСети.ГодПрокладки CustomAttributes)

        // *** End programmer edit section *** (УчастокСети.ГодПрокладки CustomAttributes)
        public virtual int ГодПрокладки
        {
            get
            {
                // *** Start programmer edit section *** (УчастокСети.ГодПрокладки Get start)

                // *** End programmer edit section *** (УчастокСети.ГодПрокладки Get start)
                int result = this.fГодПрокладки;
                // *** Start programmer edit section *** (УчастокСети.ГодПрокладки Get end)

                // *** End programmer edit section *** (УчастокСети.ГодПрокладки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (УчастокСети.ГодПрокладки Set start)

                // *** End programmer edit section *** (УчастокСети.ГодПрокладки Set start)
                this.fГодПрокладки = value;
                // *** Start programmer edit section *** (УчастокСети.ГодПрокладки Set end)

                // *** End programmer edit section *** (УчастокСети.ГодПрокладки Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Task5.ОбъектТеплопотребления.
        /// </summary>
        // *** Start programmer edit section *** (УчастокСети.ОбъектТеплопотребления CustomAttributes)

        // *** End programmer edit section *** (УчастокСети.ОбъектТеплопотребления CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ОбъектТеплопотребления"})]
        public virtual IIS.Task5.ОбъектТеплопотребления ОбъектТеплопотребления
        {
            get
            {
                // *** Start programmer edit section *** (УчастокСети.ОбъектТеплопотребления Get start)

                // *** End programmer edit section *** (УчастокСети.ОбъектТеплопотребления Get start)
                IIS.Task5.ОбъектТеплопотребления result = this.fОбъектТеплопотребления;
                // *** Start programmer edit section *** (УчастокСети.ОбъектТеплопотребления Get end)

                // *** End programmer edit section *** (УчастокСети.ОбъектТеплопотребления Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (УчастокСети.ОбъектТеплопотребления Set start)

                // *** End programmer edit section *** (УчастокСети.ОбъектТеплопотребления Set start)
                this.fОбъектТеплопотребления = value;
                // *** Start programmer edit section *** (УчастокСети.ОбъектТеплопотребления Set end)

                // *** End programmer edit section *** (УчастокСети.ОбъектТеплопотребления Set end)
            }
        }
    }
    
    /// <summary>
    /// Detail array of УчастокСети.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfУчастокСети CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfУчастокСети CustomAttributes)
    public class DetailArrayOfУчастокСети : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Task5.DetailArrayOfУчастокСети members)

        // *** End programmer edit section *** (IIS.Task5.DetailArrayOfУчастокСети members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type УчастокСети by index.
        /// </summary>
        /// <summary>
        /// Adds object with type УчастокСети.
        /// </summary>
        public DetailArrayOfУчастокСети(IIS.Task5.ОбъектТеплопотребления fОбъектТеплопотребления) : 
                base(typeof(УчастокСети), ((ICSSoft.STORMNET.DataObject)(fОбъектТеплопотребления)))
        {
        }
        
        public IIS.Task5.УчастокСети this[int index]
        {
            get
            {
                return ((IIS.Task5.УчастокСети)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Task5.УчастокСети dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
