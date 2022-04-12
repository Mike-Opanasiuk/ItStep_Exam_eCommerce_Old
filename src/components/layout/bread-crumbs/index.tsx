import { FC, Fragment } from "react";
import { Link } from "react-router-dom";
import { RenderIf } from "../../base/render-if";

interface Item {
   name: string;
   link: string;
}

interface Props {
   options: Array<Item>;
}

export const BreadCrumbs: FC<Props> = ({ options }) => {
   return (
      <div>
         {options.map((option, index) => (
            <Fragment key={index}>
               <Link to={option.link} className="text-sm font-medium hover:underline">{option.name}</Link>
               <RenderIf condition={index < options.length - 1}>
                  <span className="mx-1">/</span>
               </RenderIf>
            </Fragment>
         ))}
      </div>
   )
}