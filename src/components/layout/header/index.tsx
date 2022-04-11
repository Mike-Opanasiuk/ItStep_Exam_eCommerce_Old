import { FC } from "react";

export const Header: FC = () => {
   return (
      <header className="container mx-auto">
         <nav className="h-16 flex items-center border-b">
            <a className="flex gap-x-2" href="/">
               <img className="h-8 w-8" src="logo.png" />
               <span className="leading-8 font-medium text-gray-800">Все Буде Україна</span>
            </a>
         </nav>
      </header>
   )
}