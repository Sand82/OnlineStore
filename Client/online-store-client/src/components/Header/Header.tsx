import React from "react";
import Module from "module";
import style from "./Header.module.css";


const Header = () => {

    return (
      <header className={`${style.header} `} >        
        
        <div className={style.logoIcon}>
          All4Home
        </div>       
        
        <nav className={style.nav}>            
            <ul className={style.menu}>                
                <li>
                    <a href="#">Products</a>
                    <ul className={style.submenu}>
                        <li>
                            <a className={style.test} href="#">For car</a>
                        </li>
                        <li>
                            <a className={style.test} href="#">Home</a>
                        </li>
                        <li>
                            <a className={style.test} href="#">Drils</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href="#">About as</a>
                    <ul className={style.submenu}>
                        <li>
                            <a className={style.test} href="#">Information</a>
                        </li>
                        <li>
                            <a className={style.test} href="#">Address</a>
                        </li>
                        <li>
                            <a className={style.test} href="#">Contact as</a>
                        </li>
                    </ul>
                </li>                
            </ul>            
        </nav>
        
        <div className={style.searchMenu}>
          
        </div>

        <nav className={style.nav}>            
            <ul className={style.menu}>                
                <li>
                    <a href="#">Sing In</a>
                    <ul className={style.submenu}>
                        <li>
                            <a className={style.test} href="#">Login</a>
                        </li>
                        <li>
                            <a className={style.test} href="#">Regester</a>
                        </li>
                    </ul>
                </li>                
            </ul>            
        </nav>        
    </header>
    )
}

export default Header;