import style from './Carousel.module.css'

const Carousel = () => {

    return (
      <div className={style.carouselMainContainer}>
        <div className={style.carouselContainer}>
          <div className={style.carousel} id="carousel1">
            <img src="/assets/img/image-1.png" alt="Builder repairing the roof" />
            <section className='circleContainer'>
              <div className={style.circle}></div>
              <div className={style.circle}></div>
              <div className={style.circle}></div>
              <div className={style.circle}></div>
            </section>
            <div className={style.leftArrow}>
              <span className={`${style.chevron} ${style.left}`}>

              </span>
            </div>
            <div className={style.rightArrow}>
              <span className={`${style.chevron} ${style.right}`}>

              </span>
            </div>
          </div>
        </div>
      </div>
    )
}

export default Carousel;