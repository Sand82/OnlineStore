import style from './Carousel.module.css'

const Carousel = () => {

    return ( 
      <div className={style.carouselMainContainer}>
        <div className={style.carouselContainer}>
          <div className={style.carousel} id="carousel1">
            <section className={style.carouselScreen}>            
              <img src="/assets/img/image-1.png" alt="Builder repairing the roof" />
              <section className={style.textContainer}>
                <p>Битови стоки</p>
                <p>Всичко за дома и повече!</p>
              </section>
            </section>
            <section className={style.carouselScreen}>            
              <img src="/assets/img/image-2.png" alt="Builder repairing the roof" />
              <section className={style.textContainer}>
                <p>Битови стоки</p>
                <p>Всичко за дома и повече!</p>
              </section>
            </section>
            <section className={style.carouselScreen}>            
              <img src="/assets/img/image-3.png" alt="Builder repairing the roof" />
              <section className={style.textContainer}>
                <p>Битови стоки</p>
                <p>Всичко за дома и повече!</p>
              </section>
            </section>
            <section className={style.carouselScreen}>            
              <img src="/assets/img/image-4.png" alt="Builder repairing the roof" />
              <section className={style.textContainer}>
                <p>Битови стоки</p>
                <p>Всичко за дома и повече!</p>
              </section>
            </section>
            <section className={style.circleContainer}>
              <div className={style.circle}></div>
              <div className={style.circle}></div>
              <div className={style.circle}></div>
              <div className={style.circle}></div>            
            </section>
            <div className={style.leftArrow} id="leftArrow">
              <span className={`${style.chevron}  ${style.left}`}>

              </span>
            </div>
            <div className={style.rightArrow} id="rightArrow">
              <span className={`${style.chevron}  ${style.right}`}>

              </span>
            </div>
          </div>
        </div>
      </div>      
    )
}

export default Carousel;