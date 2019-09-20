body, .nav, button, ul, li, h1, h2, h3, p, input, textarea {
  margin: 0;
  padding: 0;
  font-family: "Ubuntu", sans-serif;
  font-size: 16px;
  line-height: 24px;
  font-weight: 500;
}

strong {
  font-weight: 500;
}

button {
  border-width: 0;
}

.header__top {
  text-transform: uppercase;
  display: flex;
  position: absolute;
  top: 35px;
  left: calc(50% - 57.5px);
}

.logo {
  width: 115px;
  height: 76px;
}

.header__phone {
  margin: 0 82px;
  color: white;
}

.header__link {
  text-decoration: none;
  border-bottom: 1px dashed;
  color: white;
}
.header__link .header__link:hover {
  color: #d5c5aa;
  transition: 0.2s;
}

.header__phone, .header__action {
  position: relative;
  top: 47.12px;
  white-space: nowrap;
}

@media screen and (max-width: 1024px) {
  .header__phone {
    margin: 0 35px;
    align-items: center;
  }
}
@media screen and (max-width: 825px) {
  .header__top {
    flex-direction: column;
    align-items: center;
    left: 0;
    right: 0;
  }
  .header__phone {
    margin: 15px 0;
  }
  .header__phone, .header__action {
    top: 0;
  }
}
.header__nav {
  position: absolute;
  bottom: 25px;
  justify-content: center;
  left: 0;
  right: 0;
}

.nav__list {
  display: flex;
  list-style: none;
  justify-content: center;
  text-transform: uppercase;
}
.nav__item {
  margin: 0 22.5px;
  padding: 7px 20px;
}
.nav__item_active {
  background-color: #d5c5aa;
  border-radius: 10px;
}
.nav__link {
  color: white;
  text-decoration: none;
  transition: color 0.2s;
  white-space: nowrap;
}
.nav__link:hover {
  color: #d5c5aa;
}

@media screen and (max-width: 1024px) {
  .nav__item {
    margin: 0 5px;
  }
}
@media screen and (max-width: 825px) {
  .nav__list {
    flex-direction: column;
    align-items: center;
  }
}
.header {
  height: 765px;
  background-image: url("../images/header.jpg");
  background-size: cover;
  background-position: center;
  font-weight: 500;
  position: relative;
  max-height: 100vh;
}

.section {
  padding: 156px calc(50% - 470px);
  position: relative;
}
.section:nth-child(even) {
  background-color: #eeeeee;
}

@media screen and (max-width: 1024px) {
  .section_first {
    padding: 65px 40px 80px;
  }
}
@media screen and (max-width: 900px) {
  .section_first {
    padding: 30px 40px 40px;
  }
}
.info {
  display: flex;
  justify-content: space-between;
}
.info__heading {
  font-size: 48px;
  line-height: 60px;
  font-weight: 300;
  text-transform: uppercase;
  width: 314px;
  margin: 0;
}
.info__text {
  max-width: 564px;
  line-height: 24px;
}
.info__text > :first-child {
  margin-top: 0;
}
.info__text > :nth-child(2) {
  margin: 24px 0;
}
.info__text > :last-child {
  margin-bottom: 0;
}

.highlight {
  color: #00aaef;
}

@media screen and (max-width: 1024px) {
  .info {
    flex-direction: column;
  }
  .info__heading {
    margin: 12px 0;
    font-size: 36px;
    line-height: 48px;
  }
}
.section_second {
  padding: 110px calc(50% - 470px);
}

@media screen and (max-width: 1020px) {
  .section_second {
    padding: 80px 40px;
  }
}
.section__heading {
  left: 0;
  right: 0;
  margin: auto;
  top: calc(-0.5em - 2px);
}

.heading {
  font-size: 48px;
  line-height: 48px;
  font-weight: 300;
  text-transform: uppercase;
  position: absolute;
  width: max-content;
  white-space: nowrap;
  display: block;
}
.heading::before {
  left: 0;
  content: "";
  display: block;
  position: absolute;
  bottom: -7px;
  width: calc(50% - 22px);
  height: 2px;
  background-color: #00aaef;
}
.heading::after {
  right: 0;
  content: "";
  display: block;
  position: absolute;
  bottom: -7px;
  width: calc(50% - 22px);
  height: 2px;
  background-color: #00aaef;
}
.heading__logos {
  position: absolute;
  background-image: url("../images/crown.svg");
  width: 20px;
  height: 13px;
  bottom: -17px;
  display: block;
  left: 0;
  right: 0;
  margin: auto;
}

.button {
  display: block;
  color: white;
  background-color: #00aaef;
  width: 188px;
  height: 52px;
  font-size: 14px;
  text-transform: uppercase;
  cursor: pointer;
  transition: background-color 0.2s;
  margin: 44px auto 0;
}

.button:hover {
  background: #2F80ED;
}

.photos {
  display: flex;
  justify-content: space-between;
}
.photos__img {
  height: 260px;
  object-fit: cover;
}
.photos__img_middle {
  width: calc(50% - 10px);
}
.photos__img_big {
  width: calc(66% - 10px);
}
.photos__img_small {
  width: calc(34% - 10px);
}

.photos__text {
  text-transform: uppercase;
  margin: 12px 0 35px 0;
}

.photos__link {
  color: #00aaef;
  transition: color 0.2s;
}

.photos__link:hover {
  color: #2F80ED;
}

@media screen and (max-width: 700px) {
  .photos__img {
    height: 160px;
  }
}
@media screen and (max-width: 1020px) {
  .section_third {
    padding: 80px 40px;
  }
}
.consultation {
  display: flex;
  justify-content: space-between;
}
.consultation__text {
  max-width: 480px;
  padding-right: 72px;
}
.consultation__heading {
  font-size: 32px;
  line-height: 40px;
  margin-bottom: 24px;
  font-weight: normal;
}
.consultation__form {
  width: 380px;
}

@media screen and (max-width: 700px) {
  .consultation {
    flex-direction: column;
  }
}
.form {
  display: flex;
  flex-direction: column;
  width: 380px;
}
.form__item {
  margin-bottom: 8px;
  width: 100%;
  height: 100%;
  align-self: center;
}
.form__input, .form__button {
  width: 100%;
  line-height: 54px;
  margin-top: 0;
}

@media screen and (max-width: 700px) {
  .consultation__text {
    padding-bottom: 30px;
  }
}
.input {
  text-align: center;
  font-size: 14px;
  color: #393939;
  text-transform: uppercase;
  background-color: #eeeeee;
  border: none;
  color: red;
}

.footer {
  height: 540px;
  background-image: url("../images/footer.jpg");
  background-size: cover;
  background-position: center;
  display: flex;
  justify-content: center;
}

.footer__logo {
  position: relative;
  top: 369px;
}

/*# sourceMappingURL=style.cs.map */
